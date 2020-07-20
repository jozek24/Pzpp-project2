using Moq;
using OSKManager.Model;
using OSKManager.Web.Services;
using OSKManager.Web.Tests.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xunit;

namespace OSKManager.Web.Tests.ServicesTests
{
    public class CourseServiceTests
    {
        private static HttpClient httpClient;

        public static HttpClient HttpClient
        {
            set { httpClient.BaseAddress = new Uri("https://localhost:5003/"); }
        }

        private ICourseService CourseService = new CourseService(httpClient);
        [Fact]
        public async void GetCourses()
        {
            var dbContext = new Mock<ApplicationDbContext>();

            dbContext.SetupGet(x => x.Courses).Returns(TestFunctions.GetDbSet<Course>(TestData.Courses).Object);

            var result = await CourseService.GetCourses();

            Assert.NotNull(result);
        }
    }
}
