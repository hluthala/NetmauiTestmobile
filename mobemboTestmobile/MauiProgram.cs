using mobemboTestmobile.ViewModels;
using mobemboTestmobile.ViewModels.Dashboard;
using mobemboTestmobile.ViewModels.Startup;
using mobemboTestmobile.Views;
using mobemboTestmobile.Views.Dashboard;
using mobemboTestmobile.Views.Startup;

namespace mobemboTestmobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        // Views
        builder.Services.AddSingleton<LoadingPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<TeacherDashboardPage>();
        builder.Services.AddSingleton<AdminDashboardPage>();
        builder.Services.AddSingleton<StudentDashboardPage>();
        builder.Services.AddSingleton<PlacePage>();
        builder.Services.AddSingleton<MainPage>();



        //ViewModel
        builder.Services.AddSingleton<LoadingPageViewModel>();
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<TeacherDashboardPageViewModel>();
        builder.Services.AddSingleton<AdminDashboardPageViewModel>();
        builder.Services.AddSingleton<StudentDashboardPageViewModel>();
        builder.Services.AddSingleton<PlacePageViewModel>();
        builder.Services.AddSingleton<MainPageViewModel>();


        return builder.Build();
	}
}

