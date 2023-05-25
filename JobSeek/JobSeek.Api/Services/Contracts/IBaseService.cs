using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Responses;

namespace JobSeek.Api.Services.Contracts
{
    public interface IBaseService<TEntity, TInput>
        where TEntity : BaseEntity, new()
        where TInput : class
    {
        List<TEntity> GetAll();
        ListResponse<TCustomEntity> GetAll<TCustomEntity>() where TCustomEntity : BaseEntity;
        SingleResponse<TEntity> GetById(int id);
        SingleResponse<TEntity> Create(TInput input);
        SingleResponse<TEntity> Update(int id, TInput input);
        SingleResponse<bool> Delete(int id);
    }
}