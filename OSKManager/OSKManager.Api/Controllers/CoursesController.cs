using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OSKManager.Api.Models;
using OSKManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IRepositoryService<Course> repositoryService;

        public CoursesController(IRepositoryService<Course> repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetCourses()
        {
            try
            {
                return Ok(await repositoryService.GetAllRecords());
                    //employeeRepository.GetEmployees());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Course>> GetCourse(Guid id)
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
        public async Task<ActionResult<Course>> CreateCourse(Course course)
        {
            try
            {
                if (course == null)
                {
                    return BadRequest();
                }

                var createdCourse = await repositoryService.Add(course);

                return CreatedAtAction(nameof(GetCourse), new { id = createdCourse.Id },
                    createdCourse);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error creating data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Course>> GetCourses(Guid id)
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
        public async Task<ActionResult<Course>> UpdateCourse(Course course)
        {
            try
            {
                var courseToUpdate = await repositoryService.GetSingle(course.Id);

                if (courseToUpdate == null)
                {
                    return NotFound($"Course with Id = {course.Id} not found");
                }

                return await repositoryService.Update(course);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error updating data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Course>> DeleteCourse(Guid id)
        {
            try
            {
                var courseToDelete = await repositoryService.GetSingle(id);

                if (courseToDelete == null)
                {
                    return NotFound($"Course with Id = {id} not found");
                }

                return await repositoryService.Delete(courseToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error deleting data from the database");
            }
        }
    }
}
