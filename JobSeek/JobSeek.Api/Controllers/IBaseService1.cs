namespace JobSeek.Api.Controllers
{
    public interface IBaseService<TEntity, TInput>
        where TEntity : class, new()
        where TInput : class, new()
    {
        object Set<T1, T2>();
        TEntity Set<T>(int id);
        T Set<T>(TInput entity);
    }
}