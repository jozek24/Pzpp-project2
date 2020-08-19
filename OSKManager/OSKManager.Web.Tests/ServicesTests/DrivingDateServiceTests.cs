using Moq;
using Moq.Protected;
using OSKManager.Components.Model;
using OSKManager.Web.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace OSKManager.Web.Tests.ServicesTests
{
    public class DrivingDateServiceTests
    {
        private readonly Mock<HttpClient> _mockHttp;
        private readonly DrivingDateService _service;

        public DrivingDateServiceTests()
        {
            _mockHttp = new Mock<HttpClient>();
            _service = new DrivingDateService(_mockHttp.Object);
        }

        [Fact]
        public void GetDrivingDates()
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(@"[{ ""id"": 1, ""title"": ""Cool post!""}, { ""id"": 100, ""title"": ""Some title""}]"),
            };

            handlerMock
               .Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(response);
            var httpClient = new HttpClient(handlerMock.Object);
            var drivingDateService = new DrivingDateService(httpClient);

            var retrievedDateService = drivingDateService.GetDrivingDates();

            Assert.NotNull(retrievedDateService);
            handlerMock.Protected().Verify(
               "SendAsync",
               Times.Exactly(1),
               ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get),
               ItExpr.IsAny<CancellationToken>());

            ////Arrange
            //var coursesList = new List<Course>() { new Course(), new Course() };
            //_mockRepo.Setup(repo => repo.GetAllRecords())
            //    .Returns(Task.FromResult(coursesList.AsQueryable()));

            ////Act
            //var actionResult = _controller.GetCourses();
            //var result = actionResult.Result as ObjectResult;

            ////Assert
            //Assert.NotNull(result);
            //Assert.True(result is OkObjectResult);
            //Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
        }
    }
}
