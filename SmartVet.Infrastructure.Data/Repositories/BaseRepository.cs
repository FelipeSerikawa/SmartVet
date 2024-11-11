using Microsoft.EntityFrameworkCore;
using SmartVet.Domain.Entities;
using SmartVet.Domain.Interfaces;
using SmartVet.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVet.Infrastructure.Data.Repositories
{
    public class BaseRepository <T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            _dbSet.Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            _dbSet.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
