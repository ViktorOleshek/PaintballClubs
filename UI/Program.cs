using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using UI;
using UI.Components;
using Services.Extensions;
using UI.Extensions;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

builder.Services.AddAuthorization();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddOptions<CursWorkSettings>()
                .BindConfiguration(CursWorkSettings.ConfigurationSection)
                .ValidateDataAnnotations()
                .ValidateOnStart();

builder.Services.AddApi(builder.Configuration)
                .AddServices(builder.Configuration);
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCookieMiddleware();
app.UseAuthentication();
app.UseAuthorization(); 
app.UseAntiforgery();

app.MapFallback(() => Results.Redirect("/not-found"));

app.MapStaticAssets();
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();
