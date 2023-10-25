using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PanCardView;

namespace Net_Maui_AI_Image_Generator
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseCardsView()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Oswald-Bold.ttf", "OswaldBold");
                    fonts.AddFont("Oswald-ExtraLight.ttf", "OswaldExtraLight");
                    fonts.AddFont("Oswald-Light.ttf", "OswaldLight");
                    fonts.AddFont("Oswald-Medium.ttf", "OswaldMedium");
                    fonts.AddFont("Oswald-Regular.ttf", "OswaldRegular");
                    fonts.AddFont("Oswald-SemiBold.ttf", "OswaldSemiBold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}