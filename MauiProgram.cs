using Microsoft.Extensions.Logging;
using ProjetoViagemOnboarding.ViewModels;
using ProjetoViagemOnboarding.Views;
using ViagemOnboarding;

namespace ProjetoViagemOnboarding
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<OnboardingViewModel>();
            builder.Services.AddTransient<ViagemOnboardingPage>();


            return builder.Build();
        }
    }
}