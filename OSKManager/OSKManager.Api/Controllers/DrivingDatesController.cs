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
    public class DrivingDatesController : ControllerBase
    {
        private readonly IRepositoryService<DrivingDate> repositoryService;

        public DrivingDatesController(IRepositoryService<DrivingDate> repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetDrivingDates()
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
        public async Task<ActionResult<DrivingDate>> GetDrivingDate(Guid id)
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
        public async Task<ActionResult<DrivingDate>> CreateDrivingDate(DrivingDate drivingDate)
        {
            try
            {
                if (drivingDate == null)
                {
                    return BadRequest();
                }

                var createdDrivingDate = await repositoryService.Add(drivingDate);

                return CreatedAtAction(nameof(GetDrivingDate), new { id = drivingDate.Id },
                    drivingDate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error creating data from the database");
            }
        }

        [HttpPut()]
        public async Task<ActionResult<DrivingDate>> UpdateDrivingDate(DrivingDate drivingDate)
        {
            try
            {
                var drivingDateToUpdate = await repositoryService.GetSingle(drivingDate.Id);

                if (drivingDateToUpdate == null)
                {
                    return NotFound($"DrivingDate with Id = {drivingDate.Id} not found");
                }

                return await repositoryService.Update(drivingDate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error updating data from the database");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<DrivingDate>> DeleteDrivingDate(Guid id)
        {
            try
            {
                var drivingDateToDelete = await repositoryService.GetSingle(id);

                if (drivingDateToDelete == null)
                {
                    return NotFound($"DrivingDate with Id = {id} not found");
                }

                return await repositoryService.Delete(drivingDateToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error deleting data from the database");
            }
        }
    }
}
