﻿namespace GippDev.Core.Repositories;

public interface IUrlRepository
{
    Task<bool> KeyExistsAsync(string key);
    Task<Uri> GetByKeyAsync(string key);
}

