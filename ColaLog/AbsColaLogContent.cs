using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog;

public class AbsColaLogContent : AbsColaLogFace
{
    protected AbsColaLogContent(EnumLogLevel logLevel, LogConfig config, IServiceCollection? service) : base(logLevel,
        config, service)
    {
    }

    public override LogResponse? WriteLog(LogInfo log)
    {
        return null;
    }
}