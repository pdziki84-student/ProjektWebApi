using System.Collections.Generic;

namespace RestaurantApi.Controllers
{
    public interface IWeatherForcastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}