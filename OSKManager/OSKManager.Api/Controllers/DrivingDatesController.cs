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
    }
}
