using GippDev.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace GippDev.Server.Controllers;

public class UtilityController : Controller
{
    private readonly IUrlShortener _urlShortener;

    public UtilityController(IUrlShortener urlShortener)
    {
        _urlShortener = urlShortener;
    }

    [HttpGet("/{redirectKey}")]
    public async Task<IActionResult> Index(string redirectKey)
    {
        var redirectUri = await _urlShortener.GetAsync(redirectKey);

        if (redirectUri is null)
            return View();
        else
            return Redirect(redirectUri.AbsoluteUri);
    }
}

