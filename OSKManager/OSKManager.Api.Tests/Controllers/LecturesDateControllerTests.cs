using Moq;
using OSKManager.Api.Controllers;
using OSKManager.Api.Models;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace OSKManager.Api.Tests.Controllers
{
    public class LecturesDateControllerTests
    {
        private readonly Mock<IRepositoryService<LectureDate>> _mockRepo;
        private readonly LecturesDateController lecturesDateController; 

        public Guid GuidId { get; set; } 
        public LectureDate LectureDate { get; set; }
        public string Id { get; set; } = "AC761785-ED42-11CE-DACB-00BDD0057645";

        public LecturesDateControllerTests()
        {
            _mockRepo = new Mock<IRepositoryService<LectureDate>>();
            lecturesDateController = new LecturesDateController(_mockRepo.Object);
            GuidId = Guid.Parse(Id);
            LectureDate = new LectureDate { Id = Guid.Parse(Id) };
        }

        [Fact]
        public void CreateLectureDate_IsValid()
        {
            _mockRepo.Setup(x => x.Add(LectureDate));
            _mockRepo.Object.Add(LectureDate);
            _mockRepo.Verify(x => x.Add(LectureDate), Times.Once());
        }

        [Fact]
        public void GetLecturesDate_IsValid()
        {
            //var list = new List<LectureDate>();
            //_mockRepo.Setup(x => x.GetAllRecords()).Returns(list);
        }

        [Fact]
        public void GetLectureDate_IsValid()
        {
            _mockRepo.Setup(x => x.GetSingle(GuidId)).Returns(Task.FromResult(LectureDate));
            _mockRepo.Object.GetSingle(GuidId);
            _mockRepo.Verify(x => x.GetSingle(LectureDate.Id), Times.Once);
        }

        [Fact]
        public void UpdateLectureDate_IsValid()
        {
            _mockRepo.Setup(x => x.Update(LectureDate)).Returns(Task.FromResult(LectureDate));
            _mockRepo.Object.Update(LectureDate);
            _mockRepo.Verify(x => x.Update(LectureDate), Times.Once);
        }

        [Fact]
        public void DeleteLectureDate_IsValid()
        {
            _mockRepo.Setup(x => x.Delete(LectureDate));
            _mockRepo.Object.Delete(LectureDate);

            _mockRepo.Setup(x => x.GetSingle(GuidId));
            _mockRepo.Object.GetSingle(GuidId);

            _mockRepo.Verify(x => x.Delete(LectureDate), Times.Once);
        }
    }
}

