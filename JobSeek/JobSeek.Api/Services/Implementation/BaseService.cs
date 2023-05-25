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
        public List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual ListResponse<TCustomEntity> GetAll<TCustomEntity>()
            where TCustomEntity : BaseEntity
        {
            var result = _repository.GetAll();
            if (result == null) return ListResponse<TCustomEntity>.Failed(ResponseStatus.NotFound);
            return ListResponse<TCustomEntity>.Success(result);
        }

        public virtual SingleResponse<TEntity> GetById(int id)
        {
            var result = _repository.GetById(id);
            if (result == null)
                return SingleResponse<TEntity>.Failed(ResponseStatus.NotFound);

            return SingleResponse<TEntity>.Success(result);
        }

        public virtual SingleResponse<TEntity> Create(TInput input)
        {
            var result = _repository.Create(input.Adapt<TEntity>());
            return SingleResponse<TEntity>.Success(result);
        }

        public virtual SingleResponse<TEntity> Update(int id, TInput input)
        {
            var result = _repository.GetById(id);
            if (result == null) return SingleResponse<TEntity>.Failed(ResponseStatus.NotFound);

            var resultExist = _repository.Update(id, input.Adapt<TEntity>());
            return SingleResponse<TEntity>.Success(resultExist);
        }

        public virtual SingleResponse<bool> Delete(int id)
        {
            var result = _repository.GetById(id);
            if (result == null) return SingleResponse<bool>.Failed(ResponseStatus.NotFound);

            return SingleResponse<bool>.Success(_repository.Delete(id));
        }
    }
}