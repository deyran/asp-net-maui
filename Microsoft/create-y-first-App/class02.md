# [Create Your First Application (2 of 18) | Building Apps with XAML and .NET MAUI](https://youtu.be/pTB4pZi4SVs?list=PLReL099Y5nRdDJre4TGscXx3EzV74O04X)

## Full screen for windowns SO

Open and edit the MauiProgram.cs file as shown in the code below:

```
using ...

#if WINDOWS
using Microsoft.Maui.LifecycleEvents;
#endif

namespace AdventureWorks
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            ...
#if WINDOWS
      SetWindowOptions(builder);
      //SetWindowHandlers();
#endif


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

#if WINDOWS
    public static void SetWindowOptions(MauiAppBuilder builder)
    {
      builder.ConfigureLifecycleEvents(events =>
      {
        events.AddWindows(wndLifeCycleBuilder =>
        {
          wndLifeCycleBuilder.OnWindowCreated(window =>
          {
            IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
            Microsoft.UI.WindowId win32WindowsId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
            Microsoft.UI.Windowing.AppWindow winuiAppWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(win32WindowsId);
            if (winuiAppWindow.Presenter is Microsoft.UI.Windowing.OverlappedPresenter p) {
              p.Maximize();
              //p.IsResizable = false;
              //p.IsMaximizable = false;
              //p.IsMinimizable = false;
            }
          });
        });
      });
    }
#endif


    }
}
```

https://youtu.be/pTB4pZi4SVs?list=PLReL099Y5nRdDJre4TGscXx3EzV74O04X&t=1106