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
        public void CreateCourse_ActionExecutes_ReturnsBadRequest()
        {
            Course course = null;
          

            var actionResult = _controller.CreateCourse(course);
            var result = actionResult.Result.Result as BadRequestResult;
            Assert.NotNull(result);
            Assert.IsType<BadRequestResult>(result);   
            Assert.Equal(StatusCodes.Status400BadRequest, result.StatusCode);

        }
        [Fact]
        public void CreateCoures_ActironExecute_ReturnsCreatedAtAction()
        {
            Course emp = null;
            _mockRepo.Setup(r => r.Add(It.IsAny<Course>()))
                .Callback<Course>(x => emp = x);

            var course = new Course();
            {
                course.ActualPrice = 1200;
                course.Name = "Do testu";
                    
            };
            _controller.CreateCourse(course);

            _mockRepo.Verify(x => x.CreateEmployee(It.IsAny<Employee>()), Times.Once);

            Assert.Equal(emp.Name, employee.Name);
            Assert.Equal(emp.Age, employee.Age);
            Assert.Equal(emp.AccountNumber, employee.AccountNumber);
        }
    }
    }
}
