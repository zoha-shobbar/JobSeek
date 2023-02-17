using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;

namespace JobSeek.Api.Repository
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private readonly DataContext _dbcontext;

        public JobCategoryRepository(DataContext context)
        {
            _dbcontext = context;
        }

        public List<JobCategory> GetAll()
        {
            return _dbcontext.JobCategories.ToList();
        }

        public JobCategory GetById(int id)
        {
            var jobCategory = _dbcontext.JobCategories
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

            return jobCategory;
        }
        public JobCategory Create(JobCategory jobCategory)
        {
            _dbcontext.JobCategories.Add(jobCategory);
            _dbcontext.SaveChanges();
            return jobCategory;
        }

        public bool Delete(int jobCategoryId)
        {
            throw new NotImplementedException();
        }

    }
}
