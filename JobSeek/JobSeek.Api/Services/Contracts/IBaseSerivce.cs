using JobSeek.Api.Models.Entities.Common;

namespace JobSeek.Api.Services.Contracts
{
    public interface IBaseService<TEntity, TInput>
        where TEntity : BaseEntity, new()
        where TInput : class
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Create(TInput input);
        TEntity Update(int id, TInput input);
        bool Delete(int id);

    }
}
