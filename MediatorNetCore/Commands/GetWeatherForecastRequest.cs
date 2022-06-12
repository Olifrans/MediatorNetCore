using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorNetCore.Commands
{
    public class GetWeatherForecastRequest : IRequest<IEnumerable<WeatherForecastResponse>>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
