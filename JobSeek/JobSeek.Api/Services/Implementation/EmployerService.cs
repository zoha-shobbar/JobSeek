using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using JobSeek.Api.Services.Contracts;
using System.Data;
using System.Text.RegularExpressions;

namespace JobSeek.Api.Services.Implementation
{
    public class EmployerService : BaseService<Employer, EmployerInput>, IEmployerService
    {
        public EmployerService(IBaseRepository<Employer> repository) : base(repository)
        { }

        public override Employer Create(EmployerInput input)
        {
            var employer = GetAll()
                .Where(x => x.RegisterId == input.RegisterId)
                .Any();
            if (employer) throw new Exception("the employer alredy exist");

            Regex regexRegisterId = new Regex(@"^[1-9]\d*$");
            if (input.RegisterId.Trim().Length <= 2 && !regexRegisterId.IsMatch(input.RegisterId))
                throw new Exception(" the registerId is invalid");

            Regex regexEmail = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            if (!regexEmail.IsMatch(input.Email)) throw new Exception("the email is invalid");

            Regex regexPhoneNumber = new Regex(@"^0[0-9]{2,}[0-9]{7,}$");
            if (!regexPhoneNumber.IsMatch(input.PhoneNumber)) throw new Exception("the phoneNumber is invalid");

            Regex regexPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            if (input.Password.Trim().Length < 8 && !regexPassword.IsMatch(input.Password))
                throw new Exception("the password is invalid");

            Regex regexAddress = new Regex(@"^[\w\s\d.,#-]+$");
            if (!regexAddress.IsMatch(input.Address)) throw new Exception("the address is invalid");

            Regex regexCompanylicenseNumber = new Regex(@"^\d{3}-\d{2}-\d{5}$");
            if (!regexCompanylicenseNumber.IsMatch(input.CompanyLicenseNumber))
                throw new Exception("the companyLicenseNumber is invalid");

            Regex regexNumberOfCompanyMembers = new Regex(@"^\d+$");
            if (input.NumberOfCompanyMembers.Trim().Length < 2
                && !regexNumberOfCompanyMembers.IsMatch(input.NumberOfCompanyMembers))
                throw new Exception("the numberOfCompanyMembers is invalid");

            Regex regexSiteAddress = new Regex(@"^(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ;,./?%&=]*)?$");
            if (!regexSiteAddress.IsMatch(input.SiteAddress)) throw new Exception("the siteAddress is invalid");

            Regex regexCompanyName = new Regex(@"^[آ-ی\s]+$");
            if (!regexCompanyName.IsMatch(input.CompanyName))
                throw new Exception("the companyName is invalid");

            return Create(input);
        }

        public override Employer Update(int id, EmployerInput input)
        {
            var existedEmployer = GetById(id);

            if (existedEmployer == null) throw new Exception("not found!");

            var isRegisterIdExist = GetAll()
               .Where(x => x.RegisterId == input.RegisterId && x.Id != id)
               .Any();

            if (isRegisterIdExist) throw new Exception("the employer alredy exist");

            Regex regexRegisterId = new Regex(@"^[1-9]\d*$");
            if (input.RegisterId.Trim().Length <= 2 && !regexRegisterId.IsMatch(input.RegisterId))
                throw new Exception(" the registerId is invalid");

            Regex regexEmail = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");
            if (!regexEmail.IsMatch(input.Email)) throw new Exception("the email is invalid");

            Regex regexPhoneNumber = new Regex(@"^0[0-9]{2,}[0-9]{7,}$");
            if (!regexPhoneNumber.IsMatch(input.PhoneNumber)) throw new Exception("the phoneNumber is invalid");

            Regex regexPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
            if (input.Password.Trim().Length < 8 && !regexPassword.IsMatch(input.Password))
                throw new Exception("the password is invalid");

            Regex regexAddress = new Regex(@"^[\w\s\d.,#-]+$");
            if (!regexAddress.IsMatch(input.Address)) throw new Exception("the address is invalid");

            Regex regexCompanylicenseNumber = new Regex(@"^\d{3}-\d{2}-\d{5}$");
            if (!regexCompanylicenseNumber.IsMatch(input.CompanyLicenseNumber))
                throw new Exception("the companyLicenseNumber is invalid");

            Regex regexNumberOfCompanyMembers = new Regex(@"^\d+$");
            if (input.NumberOfCompanyMembers.Trim().Length < 2
                && !regexNumberOfCompanyMembers.IsMatch(input.NumberOfCompanyMembers))
                throw new Exception("the numberOfCompanyMembers is invalid");

            Regex regexSiteAddress = new Regex(@"^(http(s)?://)?([\w-]+\.)+[\w-]+(/[\w- ;,./?%&=]*)?$");
            if (!regexSiteAddress.IsMatch(input.SiteAddress)) throw new Exception("the siteAddress is invalid");

            Regex regexCompanyName = new Regex(@"^[آ-ی\s]+$");
            if (!regexCompanyName.IsMatch(input.CompanyName))
                throw new Exception("the companyName is invalid");

            return Update(id, input);
        }

        public override bool Delete(int id)
        {
            var existedEmployer = GetById(id);

            if (existedEmployer == null) throw new Exception("not found!");

            var Employer = GetAll<Job>()
                .Where(x => x.EmployerId == id)
                .Any();

            if (Employer) throw new Exception("alredy in use");

            return Delete(id);
        }
    }
}