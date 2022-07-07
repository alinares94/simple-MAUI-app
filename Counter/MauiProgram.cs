using Counter.Handlers;
using Counter.Services;
using Counter.ViewModels;
using Counter.Views;
using Counter.Platforms.Services;

namespace Counter;

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

		//Dependency Injection Dialogs
		// --------------------------------------------------------
		builder.Services.AddSingleton<MainView>();
		builder.Services.AddSingleton<MainViewModel>();
        // --------------------------------------------------------

        //Handlers
        // --------------------------------------------------------

        // 1 Forma (- comodo, + organizado)
        CustomButtonHandler.Handle();

        // 2 Forma (+ comodo, - organizado)
        //        Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        //        {
        //#if ANDROID
        //            handler.PlatformView.SetBackgroundColor(Colors.BlueViolet.ToPlatform());
        //#elif iOS
        //            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
        //#endif
        //        });
        // --------------------------------------------------------

        //Dependency Services
        // --------------------------------------------------------
        builder.Services.AddTransient<IDeviceOrientationService, DeviceOrientationService>();
        // --------------------------------------------------------

        return builder.Build();
	}
}
