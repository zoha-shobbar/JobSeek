using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;

namespace JobSeek.Api.Repository
{
    public class JobCategoty : IJobCategory
    {
        private readonly DataContext _context;

        public JobCategoty(DataContext context)
        {
            this._context = context;
        }

        public List<JobCategory> GetAll()
        {
        }

        public JobCategory Create(JobCategory jobCategory)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int jobCategoryId)
        {
            throw new NotImplementedException();
        }

    }
}
