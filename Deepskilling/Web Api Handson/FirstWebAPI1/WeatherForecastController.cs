using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new[] { "Sunny", "Cloudy", "Rainy" };
    }
}