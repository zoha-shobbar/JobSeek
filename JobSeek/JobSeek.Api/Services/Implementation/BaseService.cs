using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
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

        public List<TCustomEntity> GetAll<TCustomEntity>() 
            where TCustomEntity : BaseEntity
        {
            return _repository.GetAll<TCustomEntity>();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public TEntity Create(TInput input)
        {
            var entity = input.Adapt<TEntity>();

            return _repository.Create(entity);
        }
        public TEntity Update(int id, TInput input)
        {
            var existedEntity = _repository.GetById(id);

            if (existedEntity == null)
                throw new Exception("this is not found!");

            var entity = input.Adapt<TEntity>();

            return _repository.Update(id, entity);
        }
        public bool Delete(int id)
        {
            var existedEntity = _repository.GetById(id);

            if (existedEntity == null)
                throw new Exception("this is not found!");

            return _repository.Delete(id);
        }
    }
}
