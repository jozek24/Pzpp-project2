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
    public class AdministratorsController : ControllerBase 
    {
        private readonly IRepositoryService<Administrator> repositoryService;

        public AdministratorsController(IRepositoryService<Administrator> repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAdministrators()
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
        public async Task<ActionResult<Administrator>> GetAdministrator(Guid id)
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
        public async Task<ActionResult<Administrator>> CreateAdministrator(Administrator administrator)
        {
            try
            {
                var createdAdministrator = await repositoryService.Add(administrator);

                return CreatedAtAction(nameof(CreateAdministrator), new { id = createdAdministrator.Id },
                    createdAdministrator);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error creating data from the database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Administrator>> UpdateAdministrator(Guid id, Administrator administrator)
        {
            try
            {
                if (id != administrator.Id)
                {
                    return BadRequest("Administrator ID mismatch");
                }

                var administratorToUpdate = await repositoryService.GetSingle(id);

                if (administratorToUpdate == null)
                {
                    return NotFound($"Administrator with Id = {id} not found");
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
        public async Task<ActionResult<Administrator>> DeleteAdministrator(Administrator administrator)
        {
            try
            {
                var administratorToDelete = await repositoryService.GetSingle(administrator.Id);

                if (administratorToDelete == null)
                {
                    return NotFound($"Administrator with Id = {administrator.Id} not found");
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
