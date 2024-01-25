using Microsoft.Extensions.Caching.Memory;
using MillEngine.ScryfallClient;
using Xunit.Abstractions;

namespace MillEngine.ScryfallClient.Tests;

public class UnitTest1
{

    private readonly ITestOutputHelper output;

    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
    }
    
    
    [Fact]
    public void NotNull()
    {
        var httpClient = new HttpClient();
        var memoryCache = new MemoryCache(new MemoryCacheOptions());
        string baseAddress = "https://api.scryfall.com";
        TimeSpan cacheTime = TimeSpan.FromMinutes(30);
        
        var scryfallClient = new ScryfallClient(httpClient, memoryCache, baseAddress, cacheTime);
        
        Assert.NotNull(scryfallClient);
        
    }

    [Fact]
    public async void RandomCardCache()
    {
        var httpClient = new HttpClient();
        var memoryCache = new MemoryCache(new MemoryCacheOptions());
        string baseAddress = "https://api.scryfall.com";
        TimeSpan cacheTime = TimeSpan.FromMinutes(30);
        
        var scryfallClient = new ScryfallClient(httpClient, memoryCache, baseAddress, cacheTime);

        
        // Cache should be disabled so these 2 cards should be different
        var randomCard1 = await scryfallClient.CardsClient.GetRandom();
        var randomCard2 = await scryfallClient.CardsClient.GetRandom();
        
        
        // Even if the same card is somehow gotten then ReferenceEquals should return false
        output.WriteLine($"Object.ReferenceEquals: {Object.ReferenceEquals(randomCard1, randomCard2)}");
        output.WriteLine($"HashCode 1: {randomCard1.GetHashCode()}");
        output.WriteLine($"HashCode 2: {randomCard2.GetHashCode()}");
        
        Assert.NotSame(randomCard1, randomCard2);
        

        
        // Same name != same card print so we need to use the uuid
        Assert.NotEqual(randomCard1.Id, randomCard2.Id);
    }

    [Fact]
    public async void GetCardById()
    {
        var httpClient = new HttpClient();
        var memoryCache = new MemoryCache(new MemoryCacheOptions());
        string baseAddress = "https://api.scryfall.com";
        TimeSpan cacheTime = TimeSpan.FromMinutes(30);
        
        var scryfallClient = new ScryfallClient(httpClient, memoryCache, baseAddress, cacheTime);

        // Muldrotha the Gravetide
        // https://scryfall.com/card/dom/199/muldrotha-the-gravetide
        Guid id = new Guid("c654737d-34ac-42ff-ae27-3a3bbb930fc1");
        
        // Cache should be disabled so these 2 cards should be different
        var card = await scryfallClient.CardsClient.GetById(id);
        output.WriteLine($"Real Card Name: {card.Name}");
        output.WriteLine($"Real Card ID: {card.Id}");
        
        Assert.Equal("Muldrotha, the Gravetide", card.Name);
        Assert.Equal(id, card.Id);
    }

    [Fact]
    public async void UsedCache()
    {
        var httpClient = new HttpClient();
        var memoryCache = new MemoryCache(new MemoryCacheOptions());
        string baseAddress = "https://api.scryfall.com";
        TimeSpan cacheTime = TimeSpan.FromMinutes(30);
        
        var scryfallClient = new ScryfallClient(httpClient, memoryCache, baseAddress, cacheTime);

        Guid id = new Guid("58cbcf51-3824-4ab3-89e3-cdcc1a0c7267");

        // The object references should be the same if IMemoryCache retrieved the object from in-memory cache
        var card1 = await scryfallClient.CardsClient.GetById(id);
        var card2 = await scryfallClient.CardsClient.GetById(id);
        
        Assert.Same(card1, card2);
    }
}