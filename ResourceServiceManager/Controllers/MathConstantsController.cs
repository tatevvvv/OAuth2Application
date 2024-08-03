// ResourceController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MathConstantsController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetPIConstant()
    {
        return Ok(3.14);
    }
}
