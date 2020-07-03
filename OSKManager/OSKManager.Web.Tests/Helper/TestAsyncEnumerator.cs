using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OSKManager.Web.Tests.Helper
{
    internal class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;

        public TestAsyncEnumerator(IEnumerator<T> _inner)
        {
            this._inner = _inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public T Current => throw new NotImplementedException();

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> MoveNextAsync()
        {
            throw new NotImplementedException();
        }
    }
}
