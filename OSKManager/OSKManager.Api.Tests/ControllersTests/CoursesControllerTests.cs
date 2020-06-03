using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;
using OSKManager.Api.Controllers;
using OSKManager.Api.Models;
using OSKManager.Model;
using Xunit;

namespace OSKManager.Api.Tests.ControllersTests
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
        public void GetCourses_WhenCalled_ReturnCourses()
        {
            //Arrange
            var coursesList = new List<Course>() { new Course(), new Course() };
            _mockRepo.Setup(repo => repo.GetAllRecords())
                .Returns(Task.FromResult(coursesList.AsQueryable()));

            //Act
            var actionResult = _controller.GetCourses();
            var result = actionResult.Result as ObjectResult;

            //Assert
            Assert.NotNull(result);
            Assert.True(result is OkObjectResult);
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
        }
    }
}



