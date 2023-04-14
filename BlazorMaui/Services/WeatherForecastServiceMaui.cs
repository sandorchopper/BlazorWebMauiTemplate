using BlazorWeb.Shared;
using SharedUI.Pages.WeatherData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMaui.Services
{
    public class WeatherForecastServiceMaui : iWeatherForecastService
    {
        private readonly HttpClient http;
        public WeatherForecastServiceMaui(HttpClient http) => this.http = http;
        public Task<WeatherForecast[]?> GetWeatherForecastsAsync() => http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}
