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
            _dataContext = dataContext;
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
        public Job Create(JobInput input )
        {
            Job entry = input.Adapt<Job>();
            _dataContext.Jobs.Add(entry);
            _dataContext.SaveChanges();
            return entry;

        }

        public bool Delete(int id)
        {
            var job = _dataContext.Jobs.Where(x => x.Id == id).FirstOrDefault();
            _dataContext.Jobs.Remove(job);
            _dataContext.SaveChanges();
            return true;
        }


        public Job Update(int id, JobInput Input)
        {
            var jobs = _dataContext.Jobs.Where(x => x.Id == id).FirstOrDefault();

            jobs.Details = Input.Details;
            jobs.PositionTitle = Input.PositionTitle;
            jobs.JobStatus = Input.JobStatus;
            jobs.MinSalary = Input.MinSalary;
            jobs.MaxSalary = Input.MaxSalary;
            jobs.ExpireDate = Input.ExpireDate;
            jobs.TypeCooperation = Input.TypeCooperation;
            jobs.WorkExperience = Input.WorkExperience;
            jobs.Workplace = Input.Workplace;
            jobs.Advantages = Input.Advantages;
            //jobs.Degree = Input.Degree;
            jobs.SeniorityLevel = Input.SeniorityLevel;
            jobs.IndustryType = Input.IndustryType;

            //Update New Data
            _dataContext.Jobs.Update(jobs);
            _dataContext.SaveChanges();
            return jobs;

        }
    }
}
