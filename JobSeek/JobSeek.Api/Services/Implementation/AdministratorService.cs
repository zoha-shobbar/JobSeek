using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Responses;
using JobSeek.Api.Services.Contracts;

namespace JobSeek.Api.Services.Implementation
{
    public class AdministratorService : BaseService<Administrator, AdministratorInput>, IAdministratorService
    {
        public AdministratorService(IBaseRepository<Administrator> repository) : base(repository)
        {
        }

        public override SingleResponse<Administrator> Create(AdministratorInput input)
        {
            var isEmailExist = Get()
               .Where(x => x.Email == input.Email).Any();

            if (isEmailExist) return ResponseStatus.AlreadyExist;

            var isLastName = Get()
                .Where(x => x.FirstName == input.LastName).Any();

            if (isLastName) return ResponseStatus.AlreadyExist;

            var isPhoneNumberExist = Get()
                .Where(x => x.PhoneNumber == input.PhoneNumber).Any();

            if (isPhoneNumberExist)
                return ResponseStatus.AlreadyExist;

            return Create(input);
        }

        public override SingleResponse<Administrator> Update(int id, AdministratorInput input)
        {

            var isPhoneExist = Get()
                .Where(x => x.PhoneNumber == input.PhoneNumber && x.Id != id)
                .Any();

            if (isPhoneExist) return ResponseStatus.AlreadyExist;

            var isEmailExist = Get()
                .Where(x => x.Email == input.Email && x.Id != id)
                .Any();

            if (isEmailExist) return ResponseStatus.AlreadyExist;

            var isLastName = Get()
              .Where(x => x.FirstName == input.LastName && x.Id != id)
              .Any();

            if (isLastName) return ResponseStatus.AlreadyExist;

            return Update(id, input);
        }

        public override SingleResponse<bool> Delete(int id)
        {
            var result = GetById(id);
            if (result == null) return ResponseStatus.NotFound;

            return Delete(id);
        }
    }
}