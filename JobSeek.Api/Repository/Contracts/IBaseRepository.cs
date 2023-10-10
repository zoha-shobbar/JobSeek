using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TCustomEntity> GetAll<TCustomEntity>() where TCustomEntity : BaseEntity;
        TEntity GetById(int id);
        TEntity Create(TEntity input);
        TEntity Update(int id, TEntity input);
        bool Delete(int id);
    }
}



