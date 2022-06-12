using MediatorNetCore.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecastResponse>> Get([FromQuery] GetWeatherForecastRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}