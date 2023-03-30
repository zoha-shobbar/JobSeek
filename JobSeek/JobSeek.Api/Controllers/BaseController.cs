using JobSeek.Api.Services.Contracts;
using JobSeek.Api.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TInput> : ControllerBase
        where TEntity: class , new()
        where TInput: class , new()
    {
        private readonly IBaseService<TEntity,TInput> _service;

        public BaseController(IBaseService<TEntity,TInput> service)
        {
            _service = service;
        }

        public List<TEntity> GetAll()
        {
            return (List<TEntity>)_service.Set<TEntity, TInput>();
        }

        public TEntity GetById(int id)
        {
            return _service.Set<TInput>(id);
        }

        public TEntity Create(TInput entity)
        {
            return _service.Set<TEntity>(entity);
        }

        public TEntity Update(TInput entity)
        {
            return _service.Set<TEntity>(entity);
        }

    }
}
