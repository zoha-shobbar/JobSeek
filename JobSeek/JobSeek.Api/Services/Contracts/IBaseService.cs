using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Responses;

namespace JobSeek.Api.Services.Contracts
{
    public interface IBaseService<TEntity, TInput>
        where TEntity : BaseEntity, new()
        where TInput : class
    {
        ListRespons<TCustomEntity> GetAll<TCustomEntity>() where TCustomEntity : BaseEntity;
        SingleRespons<TEntity> GetById(int id);
        ListRespons<TEntity> Create(TInput input);
        ListRespons<TEntity> Update(int id, TInput input);
        SingleRespons<bool> Delete(int id);
    }
}
