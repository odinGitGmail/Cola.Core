using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog.LogUtils;

public class LogWaringUtil : AbsLogContent
{
    public LogWaringUtil(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel, config,
        service)
    {
    }

    public override LogResponse? WriteLog(LogInfo log)
    {
        System.Console.ForegroundColor = ConsoleColor.DarkBlue;
        var logResult = WriteLogContent(log);
        System.Console.ResetColor();
        return logResult;
    }
}