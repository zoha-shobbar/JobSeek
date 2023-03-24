using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities;
using JobSeek.Api.Models.Input;
using JobSeek.Api.Repository.Contracts;
using Mapster;

namespace JobSeek.Api.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly DataContext _dataContext;

        public JobRepository(DataContext dataContext) 
        {
            this._dataContext = dataContext;
        }
        public Job create(Job job)
        {
            _dataContext.Jobs.Add(job);
            _dataContext.SaveChanges();
            return job;

        }

        public bool delete(int id)
        {
            var job = _dataContext.Jobs.Where(x => x.Id == id).FirstOrDefault();
            _dataContext.Jobs.Remove(job);
            _dataContext.SaveChanges();
            return true;
        }

        public List<Job> GetAll()
        {
            return _dataContext.Jobs.ToList();
        }

        public Job GetById(int id)
        {
            var job = _dataContext.Jobs.Where(x => x.Id == id).FirstOrDefault();
            return job;
        }

        
    }
}
