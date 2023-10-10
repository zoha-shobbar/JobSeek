﻿using JobSeek.Api.Data;
using JobSeek.Api.Models.Entities.Common;
using JobSeek.Api.Repository.Contracts;

namespace JobSeek.Api.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        private readonly DataContext _dbcontext;

        public BaseRepository(DataContext context)
        {
            _dbcontext = context;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dbcontext.Set<TEntity>();
        }
        public IQueryable<TCustomEntity> GetAll<TCustomEntity>()
            where TCustomEntity : BaseEntity
        {
            return _dbcontext.Set<TCustomEntity>();
        }

        public TEntity GetById(int id)
        {
            var entity = _dbcontext.Set<TEntity>()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            return entity;
        }
        public TEntity Create(TEntity input)
        {
            _dbcontext.Set<TEntity>().Add(input);
            _dbcontext.SaveChanges();
            return input;

        }
        public bool Delete(int id)
        {
            var entity = _dbcontext.Set<TEntity>()
                .Where(x => x.Id == id)
                .FirstOrDefault();
            _dbcontext.Set<TEntity>().Remove(entity);
            _dbcontext.SaveChanges();
            return true;
        }
        public TEntity Update(int id, TEntity input)
        {
            var entity = _dbcontext.Set<TEntity>()
              .Where(x => x.Id == id)
              .FirstOrDefault();

            _dbcontext.Set<TEntity>().Update(entity);
            _dbcontext.SaveChanges();
            return input;
        }
    }
}
