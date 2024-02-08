using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Caching.Memory;
using MillEngine.Client;
using MillEngine.ScryfallClient;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddScoped(sp => new ScryfallClient(new HttpClient(), new MemoryCache(new MemoryCacheOptions()), "https://api.scryfall.com", TimeSpan.FromMinutes(30)));

await builder.Build().RunAsync();