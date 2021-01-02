using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.WeatherInterface
{
    // decorator must implement the same interface as the class that will be decorating
    // every method from that interface must have at least a default/ basic implementation
    public class WeatherServiceLoggingDecorator : IWeatherService
    {
        private IWeatherService _weatherService;
        private ILogger<WeatherServiceLoggingDecorator> _logger;

        public WeatherServiceLoggingDecorator(IWeatherService weatherService, ILogger<WeatherServiceLoggingDecorator> logger)
        {
            _weatherService = weatherService;
            _logger = logger;
        }

        public CurrentWeather GetCurrentWeather(string location)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            CurrentWeather currentWeather = _weatherService.GetCurrentWeather(location);
            stopwatch.Stop();
            long elapsedMillis = stopwatch.ElapsedMilliseconds;
            _logger.LogWarning("Retrieved data for {location} in {@elapsedMillis} ms");
            return currentWeather;
        }

        public LocationForecast GetForecast(string location)
        {

            Stopwatch stopwatch = Stopwatch.StartNew();
            LocationForecast locationForecast = _weatherService.GetForecast(location);
            stopwatch.Stop();
            long elapsedMillis = stopwatch.ElapsedMilliseconds;
            _logger.LogWarning("Retrieved location Forest for {location} in {@elapsedMillis} ms");
            return locationForecast;


        }
    }
}
