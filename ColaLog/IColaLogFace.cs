using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;

namespace Cola.Core.ColaLog;

public interface IColaLogFace
{
    EnumLogLevel LogLevel { get; set; }
    LogConfig? Config { get; set; }

    /// <summary>
    ///     写入日志
    /// </summary>
    /// <param name="log">log</param>
    LogResponse? WriteLog(LogInfo log);
}