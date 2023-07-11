global using static Utulek.Models.PohlaviClass;
global using static Utulek.Models.Pes;
global using static Utulek.Models.Kocka;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Utulek.Data;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Utulek.Models;

var builder = WebApplication.CreateBuilder(args);

var defaultCulture = new CultureInfo("cs-CZ");
var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(defaultCulture),
    SupportedCultures = new List<CultureInfo> { defaultCulture },
    SupportedUICultures = new List<CultureInfo> { defaultCulture }
};


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<UtulekContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UtulekContext") ?? throw new InvalidOperationException("Connection string 'UtulekContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRequestLocalization(localizationOptions);
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
