using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;

namespace JobSeek.Api.Repository
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private readonly DataContext _context;

        public JobCategoryRepository(DataContext context)
        {
            _context = context;
        }

        public List<JobCategory> GetAll()
        {
            return _context.JobCategories.ToList();
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
