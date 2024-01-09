using Microsoft.AspNetCore.Mvc;
using MiniChallenge2to4.Services.WhoAreYou;

namespace MiniChallenge2to4.Controllers;

[ApiController]
[Route("[controller]")]
public class WhoAreYouController : ControllerBase
{
    private readonly IWhoAreYouService _whoAreYouService;

    public WhoAreYouController(IWhoAreYouService WhoAreYouService) 
    {
        _whoAreYouService = WhoAreYouService;
    }


    [HttpGet] 
    [Route("Name/{name}/{time}")]
    public string WhoAreYou(string name, string time)
    {
        return _whoAreYouService.WhoAreYou(name, time);
    }
}
