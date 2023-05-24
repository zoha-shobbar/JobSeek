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

        public virtual ListRespons<TCustomEntity> GetAll<TCustomEntity>()
            where TCustomEntity : BaseEntity
        {
            var result = GetAll<TCustomEntity>();
            if (result == null) return ListRespons<TCustomEntity>.Failed(ResponsStatus.NotFound);
            return ListRespons<TCustomEntity>.Success(_repository.GetAll<TCustomEntity>());
        }

        public virtual SingleRespons<TEntity> GetById(int id)
        {
            var result = GetById(id);
            if (result == null)
                return SingleRespons<TEntity>.Failed(ResponsStatus.NotFound);

            return SingleRespons<TEntity>.Success(_repository.GetById(id));
        }

        public virtual ListRespons<TEntity> Create(TInput input)
        {
            var entity = input.Adapt<TEntity>();
            return ListRespons<TEntity>.Success(_repository.Create(entity);
        }

        public virtual ListRespons<TEntity> Update(int id, TInput input)
        {
            var existedEntity = _repository.GetById(id);
            if (existedEntity == null) return ListRespons<TEntity>.Failed(ResponsStatus.NotFound);
            var entity = input.Adapt<TEntity>();

            return ListRespons<TEntity>.Success(_repository.Update(id, entity);
        }

        public virtual SingleRespons<bool> Delete(int id)
        {
            var existedEntity = _repository.GetById(id);
            if (existedEntity == null) return SingleRespons<bool>.Failed(ResponsStatus.NotFound);

            return SingleRespons<bool>.Success(_repository.Delete(id));
        }
    }
}