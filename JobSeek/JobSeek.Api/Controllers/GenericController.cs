using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using JobSeek.Api.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntity, TInput, TService> : ControllerBase
        where TEntity : BaseEntity, new()
        where TInput : class
        where TService : IBaseService<TEntity, TInput>
    {
        private readonly TService servcie;

        public GenericController(TService service)
        {
            this.servcie = service;
        }

        [HttpGet]
        public List<TEntity> Get()
        {
            return servcie.GetAll();
        }

        [HttpGet("id")]
        public TEntity Get(int id)
        {
            return servcie.GetById(id);
        }

        [HttpPost]
        public TEntity Create(TInput input)
        {
            return servcie.Create(input);
        }

        [HttpPut]
        public TEntity Update(int id, TInput input)
        {
            return servcie.Update(id, input);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return servcie.Delete(id);
        }
    }
}
