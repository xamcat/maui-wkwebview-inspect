namespace maui_app_webviewtest2;

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
			})
			.ConfigureMauiHandlers(handler =>
			{
#if __MACCATALYST__
				handler.AddHandler<WebView, maui_app_webviewtest2.Platforms.MacCatalyst.CustomWebViewHandler>();
#endif
			});

		
		return builder.Build();
	}
}
