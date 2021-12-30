namespace GippDev.Core.Services;

public interface IUrlShortener
{
    Task<Uri> GetAsync(string urlKey);
}

