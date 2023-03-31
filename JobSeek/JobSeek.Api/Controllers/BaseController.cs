using JobSeek.Api.Services.Contracts;
using JobSeek.Api.Services.Implementation;
using Microsoft.AspNetCore.Http;
using JobSeek.Api.Models.Entities.Common;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TInput> : ControllerBase
        where TEntity :BaseEntity ,new()
        where TInput : class ,new()       
    {
        private readonly IBaseSerivce<TEntity, TInput> _service;
        public BaseController(IBaseSerivce<TEntity, TInput> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("id")]
        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public TEntity Create(TInput job)
        {
            return _service.Create(job);
        }
        [HttpPut]
        public TEntity Update(int id,TInput job)
        {
            return _service.Update(id,job);
        }
        [HttpDelete]
        public bool Delete(int id)
        {
           return _service.Delete(id);
        }
    }
}
