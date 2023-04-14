using BlazorWeb.Shared;
using SharedUI.Pages.WeatherData;
using System.Net.Http.Json;

namespace BlazorWeb.Client.Services
{
    public class WeatherForecastService : iWeatherForecastService
    {
        private readonly HttpClient http;
        public WeatherForecastService(HttpClient http) => this.http = http;
        public Task<WeatherForecast[]?> GetWeatherForecastsAsync() => http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}
