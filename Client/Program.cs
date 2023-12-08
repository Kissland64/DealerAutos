using DealerAutos.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using DealerAutos.Client.Sesion;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IUsuarioAutenticadoService, UsuarioAutenticadoService>();

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
