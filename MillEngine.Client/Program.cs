using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Caching.Memory;
using MillEngine.Client;
using MillEngine.Client.MapProfiles;
using MillEngine.Client.Memory;
using MillEngine.ScryfallClient;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddAutoMapper(cfg => cfg.AddProfile<CardProfile>());

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddScoped(sp => new ScryfallClient(new HttpClient(), new MemoryCache(new MemoryCacheOptions()), "https://api.scryfall.com", TimeSpan.FromMinutes(30)));

builder.Services.AddSingleton<DeckStateContainer>();

await builder.Build().RunAsync();