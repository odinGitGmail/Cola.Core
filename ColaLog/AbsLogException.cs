using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog;

public abstract class AbsLogException : AbsColaLogException
{
    protected AbsLogException(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel,
        config, service)
    {
    }

    private LogResponse? WriteLog(string logContent)
    {
        return null;
    }
}