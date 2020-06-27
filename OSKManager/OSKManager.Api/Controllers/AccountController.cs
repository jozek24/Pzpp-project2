using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OSKManager.Api.Models;
using OSKManager.Model;

namespace OSKManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return Ok(new RegisterResult { Successful = false });
            }

            IdentityResult result;

            if (userModel.TypeOfRole == "Administrator")
            {
                var user = _mapper.Map<Administrator>(userModel);
                result = await _userManager.CreateAsync(user, userModel.Password);
                await _userManager.AddToRoleAsync(user, "Administrator");

            }
            else if (userModel.TypeOfRole == "Instructor")
            {
                var user = _mapper.Map<Instructor>(userModel);
                result = await _userManager.CreateAsync(user, userModel.Password);
                await _userManager.AddToRoleAsync(user, "Instructor");
            }
            else
            {
                var user = _mapper.Map<Student>(userModel);
                result = await _userManager.CreateAsync(user, userModel.Password);
                await _userManager.AddToRoleAsync(user, "Student");
            }

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return Ok(new RegisterResult { Successful = false, Errors = errors });

            }

            return Ok(new RegisterResult { Successful = true });
        }
    }
}