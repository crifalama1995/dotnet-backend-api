using Microsoft.AspNetCore.Mvc;

namespace DotnetBackendApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(new[]
        {
            new { Id = 1, Name = "Juan" },
            new { Id = 2, Name = "María" }
        });
    }
}
