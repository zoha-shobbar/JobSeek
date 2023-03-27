using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Services.Contracts
{
    public interface IBaseSerivce<TEntity, TInput>
        where TEntity : BaseEntity, new()
        where TInput : class
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Create(TInput job);
        bool Delete(int id);
        TEntity Update(int id, TInput job);
    }
}
