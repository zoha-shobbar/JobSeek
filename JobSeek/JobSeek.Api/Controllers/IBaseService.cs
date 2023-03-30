namespace JobSeek.Api.Controllers
{
    internal interface IBaseService<TEntity> where TEntity : class, new()
    {
    }
}