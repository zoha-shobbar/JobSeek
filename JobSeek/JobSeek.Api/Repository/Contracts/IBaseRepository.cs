using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        bool Delete(int id);
        TEntity Create(TEntity input);
        TEntity Update(int id, TEntity job);
    }
}
