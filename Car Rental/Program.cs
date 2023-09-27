using Car_Rental;
using Car_Rental.Buisness.Classes;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Classes;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IData, CompanyData>();
builder.Services.AddSingleton<Buisness>();

await builder.Build().RunAsync();
