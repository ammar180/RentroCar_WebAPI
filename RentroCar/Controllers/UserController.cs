using Microsoft.AspNetCore.Mvc;
using RentroCar.Services;

namespace RentroCar.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok();
        }
    }
}
