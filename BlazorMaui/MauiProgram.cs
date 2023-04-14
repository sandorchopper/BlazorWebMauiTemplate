using BlazorMaui.Services;
using Microsoft.Extensions.Logging;
using SharedUI.Pages.WeatherData;

namespace BlazorMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7133/") });
#else
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://uripublishedapp/") });
#endif

            builder.Services.AddSingleton<iWeatherForecastService, WeatherForecastServiceMaui>();

            return builder.Build();
        }
    }
}