using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValidadorBandeirasCartaoDeCredito.Services;

namespace ValidadorBandeirasCartaoDeCredito.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string? CardNumber { get; set; }

    public bool ShowResult { get; private set; }
    public bool IsValid { get; private set; }
    public string Brand { get; private set; } = string.Empty;

    public void OnGet()
    {
    }

    public void OnPost()
    {
        ShowResult = true;
        var (isValid, brand) = CardBrandValidator.Validate(CardNumber);
        IsValid = isValid;
        Brand = brand ?? string.Empty;
    }
}
