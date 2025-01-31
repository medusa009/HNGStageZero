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
            current_datetime = DateTime.UtcNow.ToString("o"),
            github_url = _configuration["HNG12:GitHubURL"]

        };
        
        return Ok(response);
    }
}