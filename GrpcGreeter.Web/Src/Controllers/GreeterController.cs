using Microsoft.AspNetCore.Mvc;

namespace GrpcGreeter.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class GreeterController(
    )
  : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        await Task.Delay(1);

        return Ok("a");

    }
}

