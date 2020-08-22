using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OSKManager.Web.Tests.Helper
{
    public static class TestFunctions
    {
        public static Mock<DbSet<T>> GetDbSet<T>(IQueryable<T> TestData) where T : class
        {
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;

            var MockSet = new Mock<DbSet<T>>();
            MockSet.As<IAsyncEnumerable<T>>().Setup(x => x.GetAsyncEnumerator(token)).Returns(new TestAsyncEnumerator<T>(TestData.GetEnumerator()));
            MockSet.As<IQueryable<T>>().Setup(x => x.Provider).Returns(new TestAsyncQueryProvider<T>(TestData.Provider));
            MockSet.As<IQueryable<T>>().Setup(x => x.Expression).Returns(TestData.Expression);
            MockSet.As<IQueryable<T>>().Setup(x => x.ElementType).Returns(TestData.ElementType);
            MockSet.As<IQueryable<T>>().Setup(x => x.GetEnumerator()).Returns(TestData.GetEnumerator());
            return MockSet;
        }
    }
}
