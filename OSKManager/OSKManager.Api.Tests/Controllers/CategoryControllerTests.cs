using Castle.DynamicProxy.Generators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using OSKManager.Api.Controllers;
using OSKManager.Api.Models;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OSKManager.Api.Tests.Controllers
{
    public class CategoryControllerTests
    {
        private readonly Mock<IRepositoryService<Category>> _mockRepo;
        private readonly CategoryController categoryController;

        public CategoryControllerTests()
        {
            _mockRepo = new Mock<IRepositoryService<Category>>();
            categoryController = new CategoryController(_mockRepo.Object);
        }

        [Fact]
        public void GetCategories_ReturnCategories()
        {
            var categoriesList = new List<Category> { new Category(), new Category() };
            _mockRepo.Setup(repo => repo.GetAllRecords())
                .Returns(Task.FromResult(categoriesList.AsQueryable()));

            var actionResult = categoryController.GetCategories();
            var result = actionResult.Result as ObjectResult;

            Assert.NotNull(result);
            Assert.True(result is OkObjectResult);
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
        }

        [Fact]
        public void GetCategories_DoesntReturnValue()
        {
            var categoriesList = new List<Category>();
            _mockRepo.Setup(repo => repo.GetAllRecords())
                .Returns(Task.FromResult(categoriesList.AsQueryable()));

            var actionResult = categoryController.GetCategories();
            var result = actionResult.Result as ObjectResult;

            Assert.NotNull(result);
            //Assert.Throws<ArgumentException>("Url, connection", () => _HTMLDataAccess.GetHTML(""));
        }

        [Fact]
        public void DeleteCategory_Valid()
        {
            var category = new Category { Id = Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645") };
          
            _mockRepo.Setup(x => x.Delete(category));
            _mockRepo.Object.Delete(category);

            _mockRepo.Setup(x => x.GetSingle(Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645")));
            _mockRepo.Object.GetSingle(Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645"));

            _mockRepo.Verify(x => x.Delete(category), Times.Once);
        }

        [Fact]
        public void CreateCategory_IsValid()
        {
            var category = new Category { Id = Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645") };
            _mockRepo.Setup(x => x.Add(category));
            _mockRepo.Object.Add(category);
            _mockRepo.Verify(x => x.Add(category), Times.Once());
        }

        [Fact]
        public void CreateCategory_Invalid()
        {
            var category = new Category();
            var categoriesList = new List<Category>();
            _mockRepo.Setup(repo => repo.GetAllRecords())
                .Returns(Task.FromResult(categoriesList.AsQueryable()));

            var actionResult = categoryController.CreateCategory(category);
            var result = actionResult.Result;

            Assert.NotNull(result);
        }

        [Fact]
        public void GetCategory_IsValid()
        {
            var categoriesList = new List<Category> { new Category { Id = Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645") }, new Category() };
            _mockRepo.Setup(repo => repo.GetAllRecords())
                .Returns(Task.FromResult(categoriesList.AsQueryable()));

            var actionResult = categoryController.GetCategory(Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645"));
            var result = actionResult.Result;

            Assert.NotNull(result);
        }

        [Fact]
        public void GetCategory_Invalid()
        {
            var categoriesList = new List<Category> { new Category(), new Category() };
            _mockRepo.Setup(repo => repo.GetAllRecords())
                .Returns(Task.FromResult(categoriesList.AsQueryable()));

            var actionResult = categoryController.GetCategory(Guid.Parse("AC761785-ED42-11CE-DACB-00BDD0057645"));
            var result = actionResult.Result;

            Assert.NotNull(result);
        }
    }
}
