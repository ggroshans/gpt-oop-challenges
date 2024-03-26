using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastingClassLibrary.Interfaces
{
    public interface IWeatherService

    {
        public Task<string> GetWeatherData();
    }
}
