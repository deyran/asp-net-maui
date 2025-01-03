using Microsoft.Extensions.Logging;

namespace AdventureWorks
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

#if WINDOWS
      //SetWindowOptions(builder);
      SetWindowHandlers();
#endif


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

#if WINDOWS
    public static void SetWindowHandlers()
    {
        Microsoft.Maui.Handlers.SwitchHandler.Mapper
        .AppendToMapping("Custom", (h, v) =>
            {
                // Get rid of On/Off label beside switch, to match other platforms
                h.PlatformView.OffContent = string.Empty; //"No";
                h.PlatformView.OnContent = string.Empty; //"Yes";

                h.PlatformView.MinWidth = 0;
            });
    }
#endif

    }
}
