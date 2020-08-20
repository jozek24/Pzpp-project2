using Moq;
using OSKManager.Api.Controllers;
using OSKManager.Api.Models;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Api.Tests.Controllers
{
    public class LecturesDateControllerTests
    {
        private readonly Mock<IRepositoryService<LectureDate>> _mockRepo;
        private readonly LecturesDateController lecturesDateController; 

        public LecturesDateControllerTests()
        {
            _mockRepo = new Mock<IRepositoryService<LectureDate>>();
            lecturesDateController = new LecturesDateController(_mockRepo.Object);
        }
    }
}
