namespace Cola.Core.Models.SystemBuilder;

/// <summary>
/// CorsOptions
/// </summary>
public class CorsOptions
{
    public string? CorsName { get; set; }
    public string? AllowOriginsIp { get; set; }
    public string? AllowHeaders { get; set; }
}