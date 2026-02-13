using System.Text.RegularExpressions;

namespace ValidadorBandeirasCartaoDeCredito.Services;

public static class CardBrandValidator
{
    private static readonly (string Name, Regex Pattern)[] Brands = new[]
    {
        ("MasterCard", new Regex(@"^(?:5[1-5]\d{14}|2(?:2[2-9]\d{12}|[3-6]\d{13}|7(?:0\d{12}|20\d{12})))$", RegexOptions.Compiled)),
        ("Visa (16 Dígitos)", new Regex(@"^4\d{15}$", RegexOptions.Compiled)),
        ("American Express", new Regex(@"^3[47]\d{13}$", RegexOptions.Compiled)),
        ("Diners Club", new Regex(@"^3(?:0[0-5]|[68]\d)\d{11}$", RegexOptions.Compiled)),
        ("Discover", new Regex(@"^(?:6011|65|64[4-9]|622)\d{12}$", RegexOptions.Compiled)),
        ("EnRoute", new Regex(@"^(?:2014|2149)\d{11}$", RegexOptions.Compiled)),
        ("JCB", new Regex(@"^35(?:2[89]|[3-8][0-9])\d{12}$", RegexOptions.Compiled)),
        ("Voyager", new Regex(@"^86992\d{10}$", RegexOptions.Compiled)),
        ("HiperCard", new Regex(@"^(?:606282|3841)\d{10}$", RegexOptions.Compiled)),
        ("Aura", new Regex(@"^50\d{14}$", RegexOptions.Compiled)),
    };

    /// <summary>
    /// Removes non-digit characters and checks card number against known brand regexes.
    /// </summary>
    public static (bool IsValid, string Brand) Validate(string? cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
            return (false, string.Empty);

        var digits = Sanitize(cardNumber);

        foreach (var (Name, Pattern) in Brands)
        {
            if (Pattern.IsMatch(digits))
                return (true, Name);
        }

        return (false, string.Empty);
    }

    private static string Sanitize(string input)
    {
        var chars = new char[input.Length];
        var idx = 0;
        foreach (var c in input)
        {
            if (char.IsDigit(c)) chars[idx++] = c;
        }
        return new string(chars, 0, idx);
    }
}
