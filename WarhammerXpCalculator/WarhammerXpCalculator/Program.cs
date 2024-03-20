using Microsoft.EntityFrameworkCore;
using WarhammerXpCalculator.Client.Pages;
using WarhammerXpCalculator.Components;
using WarhammerXpCalculator.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

builder.Services.AddDbContext<WarhammerXpCalcDB>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("WarhammerXpCalcDB")));

var baseAddress = builder.Configuration.GetValue<string>("BaseUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.MapControllers();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(WarhammerXpCalculator.Client._Imports).Assembly);

app.Run();
