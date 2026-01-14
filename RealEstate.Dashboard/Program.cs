using MudBlazor.Services;
using RealEstate.Dashboard.Components;
using RealEstate.Dashboard.Data;

namespace RealEstate.Dashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddScoped<AuthState>();
			builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
			builder.Services.AddScoped<AuthState>();
			builder.Services.AddMudServices();
			builder.Services.AddSingleton<HouseState>();
			builder.Services.AddSingleton<ThemeState>();
			builder.Services.AddSingleton<AnnouncementState>();
			var app = builder.Build();
			

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
