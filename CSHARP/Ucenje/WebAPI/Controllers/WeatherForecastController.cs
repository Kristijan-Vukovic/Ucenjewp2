using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpGet("Hello/{ime}")]
        //public string HelloWorld(string ime)
        //{
        //    return "Hello " + ime;
        //}

        //[HttpGet("Hello/{ime}/{prezime}/{godine}/{dostupan}")]

        [HttpGet("Hello/{ime}/{prezime}/{godine}/{dostupan}")]

        //[Route("Hello")]
        public string Helloworld(string ime, string prezime, int godine, bool dostupan)
        {
            return ime + " " + prezime + " " + godine;

            //return $"{ime} {prezime} {godine}";

            //return $" upisali ste {ime} {prezime}, koji ima {godine} godine, {dostupan}";


        }

 

    }

}
