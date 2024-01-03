using System.Reflection;
using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog;

/// <summary>
///     ColaLogFactory
/// </summary>
public class ColaLogFactory
{
    public static IColaLogFace? GetOdinLogUtils(EnumLogLevel logLevel, LogConfig? config, IServiceCollection service)
    {
        var ns = "Cola.Core.ColaLog.LogUtils";
        var classFullName = $"{ns}.Log{logLevel.ToString()}Util";
        var clsName = Assembly.GetExecutingAssembly().GetType(classFullName);
        if (clsName != null)
            return Activator.CreateInstance(clsName, logLevel, config, service) as IColaLogFace;
        return null;
    }
}