using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Instructor")]
    public class InstructorsController : ControllerBase
    {
        private readonly IRepositoryService<Instructor> repositoryService;

        public InstructorsController(IRepositoryService<Instructor> repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetInstructors()
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

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Instructor>> GetInstructor(Guid id)
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
        public async Task<ActionResult<Instructor>> CreateInstructor(Instructor instructor)
        {
            try
            {
                if (instructor == null)
                {
                    return BadRequest();
                }

                var createdInstructor = await repositoryService.Add(instructor);

                return CreatedAtAction(nameof(GetInstructor), new { id = createdInstructor.Id },
                    createdInstructor);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error creating data from the database");
            }
        }

        [HttpPut()]
        public async Task<ActionResult<Instructor>> UpdateInstructor(Instructor instructor)
        {
            try
            {
                var instructorToUpdate = await repositoryService.GetSingle(Guid.Parse(instructor.Id));

                if (instructorToUpdate == null)
                {
                    return NotFound($"Instructor with Id = {instructor.Id} not found");
                }

                return await repositoryService.Update(instructor);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error updating data from the database");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<Instructor>> DeleteInstructor(Guid id)
        {
            try
            {
                var instructorToDelete = await repositoryService.GetSingle(id);

                if (instructorToDelete == null)
                {
                    return NotFound($"Instructor with Id = {id} not found");
                }

                return await repositoryService.Delete(instructorToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error deleting data from the database");
            }
        }
    }
}
