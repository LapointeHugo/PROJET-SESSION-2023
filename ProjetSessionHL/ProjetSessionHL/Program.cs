using Microsoft.AspNetCore.Builder;
using System;
using ProjetSessionHL.Models;
using Microsoft.EntityFrameworkCore;
using ProjetSessionHL.Data;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using ProjetSessionHL.Services;
using Microsoft.AspNetCore.Identity;
using ProjetSessionHL.Initializer;

var builder = WebApplication.CreateBuilder(args); // Cr�e une web app avec les param�tres envoy�s

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// Injecter la localisation ICI
#region Localizer configuration
CultureInfo[] supportedCultures = new[]
{
    new CultureInfo("en-US"),
    new CultureInfo("fr-CA")
};
#endregion
builder.Services.AddLocalization(options => options.ResourcesPath = "Ressources");

builder.Services.AddControllersWithViews()  // Permet MVC
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddRazorPages(); // Permet utilisation de Razor

builder.Services.AddSingleton<BaseDeDonnees>(); // Permet l'utilisation du Singleton
builder.Services.AddDbContext<ProjetSessionDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ProjetSessionDbContext>();

builder.Services.AddScoped(typeof(IServiceBaseAsync<>), typeof(ServiceBaseAsync<>));
builder.Services.AddScoped<IParentService, ParentService>();

builder.Services.ConfigureApplicationCookie(options => {
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(option => { option.IdleTimeout = TimeSpan.FromMinutes(20); });

var app = builder.Build();

var locOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(locOptions.Value);


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStaticFiles(new StaticFileOptions
    {
        OnPrepareResponse = context => context.Context.Response.Headers.Add("Cache-Control", "no-cache")
    });
}
else
{
    app.UseStaticFiles();
}

app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        dbInitializer.Initialize();
    }
}

SeedDatabase();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action}/{id?}",
        defaults: new { controller = "Home", action = "Index" });
});

app.MapRazorPages();
app.UseAuthentication();;
app.Run();

// Doc
// Environnements: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-7.0
// Fichiers statiques et wwwroot : https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-7.0
// Gestion de la cache : https://learn.microsoft.com/en-us/aspnet/core/performance/caching/response?view=aspnetcore-7.0