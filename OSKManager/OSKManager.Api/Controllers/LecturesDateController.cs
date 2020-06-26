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
    public class LecturesDateController : ControllerBase
    {
        private readonly IRepositoryService<LectureDate> repositoryService;

        public LecturesDateController(IRepositoryService<LectureDate> repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet]
        public async Task<ActionResult> GetLecturesDate()
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
        public async Task<ActionResult<LectureDate>> GetLectureDate(Guid id)
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
        public async Task<ActionResult<LectureDate>> CreateLectureDate(LectureDate lectureDate)
        {
            try
            {
                if (lectureDate == null)
                {
                    return BadRequest();
                }

                var createdLectureDate = await repositoryService.Add(lectureDate);

                return CreatedAtAction(nameof(GetLectureDate), new { id = lectureDate.Id },
                    lectureDate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error creating data from the database");
            }
        }

        [HttpPut()]
        public async Task<ActionResult<LectureDate>> UpdateLectureDate(LectureDate lectureDate)
        {
            try
            {
                var lectureDateToUpdate = await repositoryService.GetSingle(lectureDate.Id);

                if (lectureDateToUpdate == null)
                {
                    return NotFound($"LectureDate with Id = {lectureDate.Id} not found");
                }

                return await repositoryService.Update(lectureDate);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error updating data from the database");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<LectureDate>> DeleteLectureDate(Guid id)
        {
            try
            {
                var lectureDateToDelete = await repositoryService.GetSingle(id);

                if (lectureDateToDelete == null)
                {
                    return NotFound($"LectureDate with Id = {id} not found");
                }

                return await repositoryService.Delete(lectureDateToDelete);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                    "Error deleting data from the database");
            }
        }
    }
}
