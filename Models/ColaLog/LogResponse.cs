using Cola.Core.Models.ColaEnums.Logs;

namespace Cola.Core.Models.ColaLog;

/// <summary>
///     LogResponse
/// </summary>
public class LogResponse
{
    public string? LogId { get; set; }
    public EnumLogLevel LogLevel { get; set; }
}