using Microsoft.AspNetCore.Mvc;

namespace Company.WebApplication1.Controllers;

[ApiController]
[Route("Test")]
public class TestController : ControllerBase
{    
    [HttpGet]
    public async Task<IActionResult> Get() 
    {        
        var response = new { Message = "Eureka!" };
        return Ok(response);
    }
}