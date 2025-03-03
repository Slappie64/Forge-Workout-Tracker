using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Forge___Workout_Tracker.Data;
using Forge___Workout_Tracker.Models;
using MudBlazor;
using MudBlazor.Services;

namespace Forge___Workout_Tracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		// App Configurations
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		// SQL Connection String
		string connectionString = "";

		// Add Database Context
		builder.Services.AddDbContext<AppDbContext>(options =>
		options.UseSqlServer(connectionString));

		// Add Application User Identity
		builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
			.AddEntityFrameworkStores<AppDbContext>();

		// MAUI Blazor Web View
		builder.Services.AddMauiBlazorWebView();
		
		// Add MudBlazor Services
		builder.Services.AddMudServices();

		// Add Authentication
		builder.Services.AddAuthorizationCore();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
