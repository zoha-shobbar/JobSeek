using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Models.Input;

namespace JobSeek.Api.Repository.Contracts
{
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Create(TEntity input);
        TEntity Update(int id, TEntity input);
        bool Delete(int id);
        void Create(Models.Input.JobInput input);
    }
}



