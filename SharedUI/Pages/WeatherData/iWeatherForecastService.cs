using BlazorWeb.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedUI.Pages.WeatherData
{
    public interface iWeatherForecastService
    {
        Task<WeatherForecast[]?> GetWeatherForecastsAsync();
    }
}
