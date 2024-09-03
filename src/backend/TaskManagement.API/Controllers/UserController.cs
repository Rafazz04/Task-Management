using Microsoft.AspNetCore.Mvc;
using TaskManagement.Communication.Requests;
using TaskManagement.Communication.Responses;

namespace TaskManagement.API.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
	public IActionResult Register(RequestRegisterUserJson register)
	{
		return Created();
	}
}
