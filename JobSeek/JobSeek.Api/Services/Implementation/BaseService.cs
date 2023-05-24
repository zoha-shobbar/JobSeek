using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Responses;
using JobSeek.Api.Services.Contracts;
using Mapster;

namespace JobSeek.Api.Services.Implementation
{
    public class BaseService<TEntity, TInput> : IBaseService<TEntity, TInput>
        where TEntity : BaseEntity, new()
        where TInput : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual ListResponse<TCustomEntity> GetAll<TCustomEntity>()
            where TCustomEntity : BaseEntity
        {
            var result = GetAll<TCustomEntity>();
            if (result == null) return ListResponse<TCustomEntity>.Failed(ResponseStatus.NotFound);
            return ListResponse<TCustomEntity>.Success(_repository.GetAll<TCustomEntity>());
        }

        public virtual SingleResponse<TEntity> GetById(int id)
        {
            var result = GetById(id);
            if (result == null)
                return SingleResponse<TEntity>.Failed(ResponseStatus.NotFound);

            return SingleResponse<TEntity>.Success(_repository.GetById(id));
        }

        public virtual ListResponse<TEntity> Create(TInput input)
        {
            var entity = input.Adapt<TEntity>();
            var result = _repository.Create(entity);
            return ListResponse<TEntity>.Success(result);
        }

        public virtual ListResponse<TEntity> Update(int id, TInput input)
        {
            var existedEntity = _repository.GetById(id);
            if (existedEntity == null) return ListResponse<TEntity>.Failed(ResponseStatus.NotFound);

            var entity = input.Adapt<TEntity>();

            var result = _repository.Update(id, entity);
            return ListResponse<TEntity>.Success(result);
        }

        public virtual SingleResponse<bool> Delete(int id)
        {
            var existedEntity = _repository.GetById(id);
            if (existedEntity == null) return SingleResponse<bool>.Failed(ResponseStatus.NotFound);

            return SingleResponse<bool>.Success(_repository.Delete(id));
        }
    }
}