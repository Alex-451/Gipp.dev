﻿using GippDev.Core.Repositories;

namespace GippDev.Core.Services;

public class UrlShortener : IUrlShortener
{
    private readonly IUrlRepository _urlRepository;

    public UrlShortener(IUrlRepository urlRepository)
    {
        _urlRepository = urlRepository;
    }

    public async Task<Uri> GetAsync(string urlKey)
    {
        if (await _urlRepository.KeyExistsAsync(urlKey))
            return await _urlRepository.GetByKeyAsync(urlKey);

        return null;
    }
}
