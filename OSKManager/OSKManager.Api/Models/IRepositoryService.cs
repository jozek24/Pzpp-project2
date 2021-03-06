﻿using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OSKManager.Api.Models
{
    public interface IRepositoryService<T> where T : class
    {
        Task<IQueryable<T>> GetAllRecords();
        Task<T> GetSingle(Guid id);
        Task<IQueryable<T>> FindBy(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        Task<T> Delete(T entity);
        Task<T> Update(T entity);
    }
}
