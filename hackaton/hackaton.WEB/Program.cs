using CurrieTechnologies.Razor.SweetAlert2;
using hackaton.WEB;
using hackaton.WEB.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://itmhackatonapi.azurewebsites.net/") });

builder.Services.AddScoped<IRepository,Repository>();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
