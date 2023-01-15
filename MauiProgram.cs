using CoffeShopApp.ViewModel;
using CoffeShopApp.Views;
using Syncfusion.Maui.Core.Hosting;

namespace CoffeShopApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.ConfigureSyncfusionCore();
        builder.Services.AddSingleton<MenuViewModel>();
        builder.Services.AddTransient<About>();
        builder.Services.AddTransient<Cart>();
        builder.Services.AddTransient<Menu>();
		return builder.Build();
	}
}
