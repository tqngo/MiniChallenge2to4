using Microsoft.AspNetCore.Mvc;
using MiniChallenge2to4.Services.Sum;

namespace MiniChallenge2to4.Controllers;

[ApiController]
[Route("[controller]")]
public class SumController : ControllerBase
{
    private readonly ISumService _sumService;

    public SumController(ISumService sumService)
    {
        _sumService = sumService;
    }

    [HttpGet] 
    [Route("Numbers/{NumberOne}/{NumberTwo}")]
    public string Numbers(string NumberOne, string NumberTwo)
    {
        return _sumService.Numbers(NumberOne, NumberTwo);
    }
    
}