using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.WeatherInterface
{
    public class WeatherServiceCachingDecorator : IWeatherService
    {
        private IWeatherService _weatherService;
        private IMemoryCache _cache;

        public WeatherServiceCachingDecorator(IWeatherService weatherService, IMemoryCache cache)
        {
            _weatherService = weatherService;
            _cache = cache;
        }

        public CurrentWeather GetCurrentWeather(string location)
        {
            String cacheKey = $"WeatherConditions::{location}";
            if (_cache.TryGetValue<CurrentWeather>(cacheKey, out var currentWeather))
            {
                return currentWeather;
            }
            else
            {
                var currentCondition = _weatherService.GetCurrentWeather(location);
                _cache.Set<CurrentWeather>(cacheKey, currentCondition, TimeSpan.FromMinutes(30));
                return currentCondition;
            }

          
        }

        public LocationForecast GetForecast(string location)
        {
            throw new NotImplementedException();
        }
    }
}
