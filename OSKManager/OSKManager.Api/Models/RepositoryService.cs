using Microsoft.EntityFrameworkCore;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OSKManager.Api.Models
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class, IEntity<Guid>
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> _set;

        public RepositoryService(ApplicationDbContext context)
        {
            _context = context;
            _set = (_context as DbContext).Set<T>();
        }

        public async Task<T> Add(T entity)
        {
            try
            {
                var result = await _set.AddAsync(entity);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception e)
            {

                throw;
            }
           
        }

        public async Task<T> Delete(T entity)
        {
            var result = await _set.FirstOrDefaultAsync(e => e.Id == entity.Id);

            if(result != null)
            {
                _set.Remove(entity);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<T> Update(T entity)
        {
            var result = await _set.FirstOrDefaultAsync(x => x.Id == entity.Id);
            try
            {
                (_context as DbContext).Entry(entity).State = EntityState.Modified;
                //System.Data.Entity.EntityState.Modified

                await _context.SaveChangesAsync();

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IQueryable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _set.Where(predicate);
            return query;
        }

        public async Task<T> GetSingle(Guid id)
        {
            return await _set.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IQueryable<T>> GetAllRecords()
        {
            return _set;
        }
    }
}
