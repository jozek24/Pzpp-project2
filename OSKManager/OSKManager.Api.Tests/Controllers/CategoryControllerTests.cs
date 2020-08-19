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
    }
}
