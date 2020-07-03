using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace OSKManager.Web.Tests.Helper
{
    internal class TestAsyncQueryProvider<TEntity> : IAsyncQueryProvider
    {
        private readonly IQueryProvider inner;

        internal TestAsyncQueryProvider(IQueryProvider inner)
        {
            this.inner = inner;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            throw new NotImplementedException();
        }

        public object Execute(Expression expression)
        {
            throw new NotImplementedException();
        }

        public TResult Execute<TResult>(Expression expression)
        {
            throw new NotImplementedException();
        }

        public TResult ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
