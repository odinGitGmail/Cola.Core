using Cola.Core.Models.ColaEnums.Logs;

namespace Cola.Core.Models.ColaLog;

/// <summary>
///     LogModel
/// </summary>
public class LogModel
{
    public string? LogId { get; set; }
    public string? LogContent { get; set; }
    public string? LogOriginalContent { get; set; }
    public string? LogMark { get; set; }
    public EnumLogLevel LogLevel { get; set; }
    public System.Exception? LogException { get; set; }
    public EnumLogSaveType[]? LogSaveType { get; set; }
}