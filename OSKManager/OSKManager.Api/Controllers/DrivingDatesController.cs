using Microsoft.AspNetCore.Authorization;
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
    }
}
