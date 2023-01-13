using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using validation_approaches.FluentValidation;
using validation_approaches.ModelBindingValidation;
using validation_approaches.ValidatableObject;

namespace validation_approaches.Controllers
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

        //Model binding validation
        [HttpPost]
        public ActionResult Post(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

        //ActionFilter usage. See program.cs how it is implemented for all controllers to validate request
        [HttpPost("ActionFilterTestMethod")]
        public ActionResult ActionFilterTestMethod(Person person)
        {
            return Ok();
        }

        //FluentValidation
        [HttpPost("FluentValidationTestMethod")]
        public ActionResult FluentValidationTestMethod(AnotherPersonModel person)
        {
            return Ok();
        }

        //IValidatableObject
        [HttpPost("IValidateObjectTestMethod")]
        public ActionResult IValidateObjectTestMethod(Movie movie)
        {
            Validator.ValidateObject(movie, new ValidationContext(movie));
            return Ok();
        }
    }
}