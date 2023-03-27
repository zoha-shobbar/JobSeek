using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Repository.Contracts;

namespace JobSeek.Api.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        private readonly DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<TEntity> GetAll()
        {
            return _dataContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            var entity = _dataContext.Set<TEntity>().Where(x => x.Id == id).FirstOrDefault();
            return entity;
        }
        public TEntity Create(TEntity entity)
        {
            _dataContext.Set<TEntity>().Add(entity);
            _dataContext.SaveChanges();
            return entity;

        }

        public bool Delete(int id)
        {
            var entity = _dataContext.Set<TEntity>().Where(x => x.Id == id).FirstOrDefault();
            _dataContext.Set<TEntity>().Remove(entity);
            _dataContext.SaveChanges();
            return true;
        }


        public TEntity Update(int id, TEntity entity)
        {
            var jobs = _dataContext.Set<TEntity>().Where(x => x.Id == id).FirstOrDefault();

            _dataContext.Set<TEntity>().Update(jobs);
            _dataContext.SaveChanges();
            return jobs;
        }
    }
}
