using MediatorNetCore.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorNetCore.Commands;
using Microsoft.AspNetCore.Mvc;

namespace MediatorNetCore.Handlers
{
    public class WeatherForecastHandle : IRequestHandler<GetWeatherForecastRequest, IEnumerable<WeatherForecastResponse>>
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<IEnumerable<WeatherForecastResponse>> Handle(GetWeatherForecastRequest request, CancellationToken cancellationToken)
        {
            var rng = new Random();
            var response = Enumerable.Range(1, 5).Select(index => new WeatherForecastResponse
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            return await Task.FromResult(response);
        }
    }
}
