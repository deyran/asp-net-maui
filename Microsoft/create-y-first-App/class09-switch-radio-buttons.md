# [Use Switch and Radio Buttons (9 of 18)](https://youtu.be/hwL-BsV5WDs?si=spbEKptQ0LvAFYb7)


## Using and customize the Switch control

1. Open the *LoginView.xaml*, insert the following code:

```
<StackLayout>
    <partial:HeaderView ViewTitle="Login page" 
                    ViewDescription="Please identify yourself" />

    <Frame Padding="10" WidthRequest="100">
        <Switch Is />
    </Frame>

</StackLayout>
```

2. To customize the Switch default label, open the *MauiProgram.cs* file and insert the code below:
   
```
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
//HERE
#if WINDOWS
      //SetWindowOptions(builder);
      SetWindowHandlers();
#endif


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

//HERE
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
```

3. AAAAA