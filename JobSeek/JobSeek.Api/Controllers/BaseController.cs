using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Responses;
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
        public ListRespons<TEntity> GetAll()
        {
            return _service.GetAll<TEntity>();
        }

        [HttpGet("id")]
        public SingleRespons<TEntity> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public ListRespons<TEntity> Create(TInput input)
        {
            return _service.Create(input);
        }

        [HttpPut]
        public ListRespons<TEntity> Update(int id, TInput input)
        {
            return _service.Update(id, input);
        }

        [HttpDelete]
        public SingleRespons<bool> Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
