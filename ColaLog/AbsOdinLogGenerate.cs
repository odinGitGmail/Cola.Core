using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;

namespace Cola.Core.ColaLog;

public abstract class AbsOdinLogGenerate : IColaLog
{
    protected LogConfig? Config;
    public abstract LogModel GenerateLog(EnumLogLevel logLevel, LogInfo log);
}