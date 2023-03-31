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
        private readonly TService _servcie;

        public BaseController(TService service)
        {
            _servcie = service;
        }

        [HttpGet]
        public List<TEntity> Get()
        {
            return _servcie.GetAll();
        }

        [HttpGet("id")]
        public TEntity Get(int id)
        {
            return _servcie.GetById(id);
        }

        [HttpPost]
        public TEntity Create(TInput input)
        {
            return _servcie.Create(input);
        }

        [HttpPut]
        public TEntity Update(int id, TInput input)
        {
            return _servcie.Update(id, input);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _servcie.Delete(id);
        }
    }
}
