using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OSKManager.Api.Models;
using OSKManager.Model;

namespace OSKManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepositoryService<Category> repositoryService;

        public CategoryController(IRepositoryService<Category> repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet]
        
        public async Task<ActionResult> GetCategories()
        {
            try
            {
                return Ok(await repositoryService.GetAllRecords());
             
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetCategory(Guid id)
        {
            try
            {
                var result = await repositoryService.GetSingle(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Course>> CreateCategory(Category category)
        {
            try
            {
                if (category == null)
                {
                    return BadRequest();
                }

                var createdCategory = await repositoryService.Add(category);

                return CreatedAtAction(nameof(GetCategory), new { id = createdCategory.Id },
                    createdCategory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error creating data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetCategories(Guid id)
        {
            try
            {
                var result = await repositoryService.GetSingle(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPut()]
        public async Task<ActionResult<Category>> UpdateCCategory(Category category)
        {
            try
            {
                var categoryToUpdate = await repositoryService.GetSingle(category.Id);

                if (categoryToUpdate == null)
                {
                    return NotFound($"Course with Id = {category.Id} not found");
                }

                return await repositoryService.Update(category);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error updating data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Category>> DeleteCourse(Guid id)
        {
            try
            {
                var categoryToDelete = await repositoryService.GetSingle(id);

                if (categoryToDelete == null)
                {
                    return NotFound($"Course with Id = {id} not found");
                }

                return await repositoryService.Delete(categoryToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error deleting data from the database");
            }
        }
    }
}