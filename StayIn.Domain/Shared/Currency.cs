namespace StayIn.Domain.Shared;
public record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency Npr = new("NPR");
    public static readonly Currency Usd = new("USD");

    private Currency(string code) => Code = code;
    public string Code { get; set; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code) ??
            throw new ApplicationException("Invalid currency code");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Npr,
        Usd
    };

}
