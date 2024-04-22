using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using System.Runtime;
using ImageViewApp.Configuration;
using ImageViewApp.Services;
using ImageViewApp.Services.Interfaces;
using ImageViewApp.ViewModels;
using ImageViewApp.Views;

namespace ImageViewApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .Logging.AddDebug();

            // Add the following line to use the MauiCommunityToolkit

            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<IYodaService, YodaServices>();
            mauiAppBuilder.Services.AddTransient<ISettings, ConstantSettings>();

            // More services registered here.

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<FunFactsPageViewModel>();
            /*mauiAppBuilder.Services.AddSingleton<QuestionViewModel>();
            mauiAppBuilder.Services.AddSingleton<AnswerViewModel>();*/

            // More view-models registered here.

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<FunFactsPageView>();
            /*mauiAppBuilder.Services.AddSingleton<YodaQuestionPage>();
            mauiAppBuilder.Services.AddSingleton<YodaAnswerPage>();*/

            // More views registered here.

            return mauiAppBuilder;
        }
    }
}
