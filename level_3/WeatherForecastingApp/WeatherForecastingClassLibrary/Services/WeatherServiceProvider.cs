using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastingClassLibrary.Interfaces;

namespace WeatherForecastingClassLibrary.Services
{
    public class WeatherServiceProvider : IWeatherService 
    { 
        
        private readonly HttpClient _httpClient;

        public WeatherServiceProvider(HttpClient httpClient) 
        {
            _httpClient = httpClient;  
        }
        public Task<string> GetWeatherData()
        {

        }
    }
}
