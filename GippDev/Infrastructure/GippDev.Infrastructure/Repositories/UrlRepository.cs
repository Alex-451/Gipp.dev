using GippDev.Core.Repositories;
using System.Collections;

namespace GippDev.Infrastructure.Repositories;

public class UrlRepository : IUrlRepository
{
    private readonly InMemoryCache<Hashtable> _urls;

    public UrlRepository(JsonStorage storage)
    {
        _urls = new InMemoryCache<Hashtable>(() => storage.Get<Hashtable>("redirectUrls.json"), TimeSpan.FromDays(1));
    }

    public Task<Uri> GetByKeyAsync(string key) => Task.FromResult(new Uri((string)_urls.GetValue()[key]));

    public Task<bool> KeyExistsAsync(string key) => Task.FromResult(_urls.GetValue().ContainsKey(key));
}

