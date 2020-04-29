using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OSKManager.Api.Models;
using OSKManager.Model;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSKManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : ControllerBase 
    {
        private readonly IRepositoryService<Administrator> repositoryService;

        public AdministratorController(IRepositoryService<Administrator> repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            try
            {
                return Ok(repositoryService.GetAllRecords());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Administrator>> GetUser(Guid id)
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
        public async Task<ActionResult<Administrator>> CreateUser(Administrator administrator)
        {
            try
            {
                var createdUser = await repositoryService.Add(administrator);

                return CreatedAtAction(nameof(CreateUser), new { id = createdUser.Id },
                    createdUser);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error creating data from the database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Administrator>> UpdateUser(Guid id, Administrator administrator)
        {
            try
            {
                if (id != administrator.Id)
                {
                    return BadRequest("User ID mismatch");
                }

                var userToUpdate = await repositoryService.GetSingle(id);

                if (userToUpdate == null)
                {
                    return NotFound($"User with Id = {id} not found");
                }

                return await repositoryService.Update(administrator);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error updating data from the database");
            }
        }

        [HttpDelete("id:int")]
        public async Task<ActionResult<Administrator>> DeleteUser(Administrator administrator)
        {
            try
            {
                var userToDelete = await repositoryService.GetSingle(administrator.Id);

                if (userToDelete == null)
                {
                    return NotFound($"User with Id = {administrator.Id} not found");
                }

                return await repositoryService.Delete(administrator);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error deleting data from the database");
            }
        }
    }
}
