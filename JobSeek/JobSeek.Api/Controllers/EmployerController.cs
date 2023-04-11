using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Services.Contracts;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using NuGet.Protocol.Core.Types;
using System.Configuration;

namespace JobSeek.Api.Controllers
{
    public class EmployerController: BaseController<IBaseService<Employer, EmployerInput>, Employer, EmployerInput>
    {
        public EmployerController(IBaseService<Employer, EmployerInput> service) : base(service)
        {
        }
    }
}


