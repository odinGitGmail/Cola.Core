using Cola.Core.Models.ColaEnums.Logs;

namespace Cola.Core.Models.ColaLog;

public class LogInfo
{
    public long? LogId { get; set; } = null;
    public string LogContent { get; set; } = "";
    public string LogMark { get; set; } = "";
    public EnumLogSaveType[] LogSaveType { get; set; } = { EnumLogSaveType.File };
}