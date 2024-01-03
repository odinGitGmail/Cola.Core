using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog.LogUtils;

public class LogErrorUtil : AbsLogException
{
    public LogErrorUtil(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel, config,
        service)
    {
    }

    public override LogResponse? WriteLog(LogInfo log)
    {
        System.Console.ForegroundColor = ConsoleColor.Red;
        var logResult = WriteLogContent(log);
        System.Console.ResetColor();
        return logResult;
    }
}