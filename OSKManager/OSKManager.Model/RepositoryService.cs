using Microsoft.EntityFrameworkCore;
using Microsoft.Exchange.WebServices.Data;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OSKManager.Api.Models
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class, IEntity<int>
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
            var result = await _set.AddAsync(entity);//appDbContext.Employees.AddAsync(employee);
            _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<T> Delete(T entity)
        {
            //var result = await _context.Find(T.Id);
            //var result = await _context.Find<T>(T.Id);
            //var result = await appDbContext.Employees
            //    .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            //if (result != null)
            //{
            //    _context.Remove(result);
            //    await _context.SaveChangesAsync();
            //    return result;
            //}

            return null;
        }

        public async Task<T> Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetSingle(int id)
        {
            throw new NotImplementedException();
            //return await _context.
            //return await appDbContext.Employees
            //    .Include(e => e.Department)
            //    .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }
    }
}
