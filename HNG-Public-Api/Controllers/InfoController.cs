using Microsoft.AspNetCore.Mvc;

namespace HNG_Public_Api.Controllers;

[ApiController]
[Route("api/HNG12")]
public class InfoController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public InfoController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    // GET
    [HttpGet]
    public IActionResult GetInfo()
    {
        var response = new
        {
            email = _configuration["HNG12:Email"],
            timestamp = DateTime.UtcNow.ToString("o"),
            github = _configuration["HNG12:GitHubURL"]

        };
        
        return Ok(response);
    }
}