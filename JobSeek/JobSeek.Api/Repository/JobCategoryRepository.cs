using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

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
        public JobCategory Create(JobCategory input)
        {
            _dbcontext.JobCategories.Add(input);
            _dbcontext.SaveChanges();
            return input;
        }

        public bool Delete(int id)
        {
            var jobCategory = _dbcontext.JobCategories
                .Where(x => x.Id == id)
                .FirstOrDefault();

            if (jobCategory == null) return false;

            _dbcontext.JobCategories.Remove(jobCategory);
            _dbcontext.SaveChanges();

            return true;
        }

        public bool Update(int id)
        {
            var jobCategory = _dbcontext.JobCategories
            .Where(x => x.Id == id)
            .FirstOrDefault();

            if (jobCategory == null) return false;

            _dbcontext.Entry(jobCategory).State = EntityState.Modified;
            _dbcontext.SaveChanges();

            return true;
        }
    }
}
