using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TService, TEntity, TInput> : ControllerBase
        where TService : IBaseService<TEntity, TInput>
        where TEntity : BaseEntity, new()
        where TInput : class
    {
        private readonly TService _service;

        public BaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<TEntity> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("id")]
        public TEntity Get(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public TEntity Create(TInput input)
        {
            return _service.Create(input);
        }

        [HttpPut]
        public TEntity Update(int id, TInput input)
        {
            return _service.Update(id, input);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
