using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OSKManager.Web.Tests.Helper
{
    internal class TestAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
    {
        public TestAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
