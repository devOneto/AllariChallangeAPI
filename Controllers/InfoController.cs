using AllariChallangeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllariChallangeAPI.Controllers;

[Controller]
[Route("[controller]")]
public class InfoController : ControllerBase
{
    public InfoController(){}
    
    [HttpGet]
    public async Task<ActionResult<Info>> Get() => new OkObjectResult( new Info { Name = "Allari Challange Project API ", Version = 1.0f } );
    
}