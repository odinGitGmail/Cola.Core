using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;

namespace Cola.Core.ColaLog;

public interface IColaLog
{
    LogModel GenerateLog(EnumLogLevel logLevel, LogInfo log);
}