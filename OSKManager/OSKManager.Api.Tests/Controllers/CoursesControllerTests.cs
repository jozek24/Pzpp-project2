using Moq;
using OSKManager.Api.Controllers;
using OSKManager.Api.Models;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
