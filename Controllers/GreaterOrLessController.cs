using Microsoft.AspNetCore.Mvc;
using MiniChallenge2to4.Services.GreaterOrLess;

namespace MiniChallenge2to4.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : ControllerBase
{
    private readonly IGreaterOrLessService _greaterOrLessService;

    public GreaterOrLessController(IGreaterOrLessService greaterOrLessService)
    {
        _greaterOrLessService = greaterOrLessService;
    }
    [HttpGet]
    [Route("Expressions/{FirstNumber}/{SecondNumber}")]

    public string Expressions(string FirstNumber, string SecondNumber)
    {
        return _greaterOrLessService.Expressions(FirstNumber, SecondNumber);
        
    }
}



