using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using OSKManager.Api.Controllers;
using OSKManager.Api.Models;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OSKManager.Api.Tests.Controllers
{

    public class CoursesControllerTests
    {
        private readonly Mock<IRepositoryService<Course>> _mockRepo;
        private readonly CoursesController _controller;
        public CoursesControllerTests()
        {
            _mockRepo = new Mock<IRepositoryService<Course>>();
            _controller = new CoursesController(_mockRepo.Object);


        }

        [Fact]
        public void DeleteCourse_WhenCalled_DeleteCourse()
        {
            var course = new Course
            {
                Id = Guid.NewGuid()
            };
            Course course2 = null;

            _mockRepo.Setup(r => r.GetSingle(course.Id))
                .Returns(Task.FromResult(course));

            var actionResult = _controller.DeleteCourse(course.Id);
            var result = actionResult.Result.Result as ObjectResult;
            Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
            Assert.Equal(StatusCodes.Status404NotFound, result.StatusCode);



        }
    }
}
