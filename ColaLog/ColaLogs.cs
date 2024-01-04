using Cola.Core.Models.ColaEnums.Logs;
using Cola.Core.Models.ColaLog;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog;

public class ColaLogs : IColaLogs
{
    public ColaLogs(LogConfigOption opt, IServiceCollection serviceProvider)
    {
        Config = opt.Config;
        Service = serviceProvider;
    }

    public IServiceCollection Service { get; set; }
    public LogConfig? Config { get; set; }

    public LogResponse? Info(LogInfo log)
    {
        var logFactory = ColaLogFactory.GetOdinLogUtils(EnumLogLevel.Info, Config, Service);
        if (logFactory == null)
        {
            throw new System.Exception("log factory 构造函数有错，没有创建LogFactory对象");
        }

        var response = logFactory.WriteLog(log);
        // Console.WriteLine(JsonConvert.SerializeObject(log));
        return response;
    }

    public LogResponse? Info(string logInfo)
    {
        var logFactory = ColaLogFactory.GetOdinLogUtils(EnumLogLevel.Info, Config, Service);
        if (logFactory == null)
        {
            throw new System.Exception("log factory 构造函数有错，没有创建LogFactory对象");
        }

        var response = logFactory.WriteLog(new LogInfo { LogContent = logInfo });
        return response;
    }

    public LogResponse? Waring(LogInfo log)
    {
        var logFactory = ColaLogFactory.GetOdinLogUtils(EnumLogLevel.Info, Config, Service);
        if (logFactory == null)
        {
            throw new System.Exception("log factory 构造函数有错，没有创建LogFactory对象");
        }

        var response = logFactory.WriteLog(log);
        // Console.WriteLine(JsonConvert.SerializeObject(log));
        return response;
    }

    public LogResponse? Waring(string logWaring)
    {
        var logFactory = ColaLogFactory.GetOdinLogUtils(EnumLogLevel.Info, Config, Service);
        if (logFactory == null)
        {
            throw new System.Exception("log factory 构造函数有错，没有创建LogFactory对象");
        }

        var response = logFactory.WriteLog(new LogInfo { LogContent = logWaring });
        return response;
    }

    public LogResponse? Error(ExceptionLog log)
    {
        var logFactory = ColaLogFactory.GetOdinLogUtils(EnumLogLevel.Info, Config, Service);
        if (logFactory == null)
        {
            throw new System.Exception("log factory 构造函数有错，没有创建LogFactory对象");
        }

        var response = logFactory.WriteLog(log);
        // Console.WriteLine(JsonConvert.SerializeObject(log));
        return response;
    }

    public LogResponse? Error(System.Exception ex)
    {
        var logFactory = ColaLogFactory.GetOdinLogUtils(EnumLogLevel.Info, Config, Service);
        if (logFactory == null)
        {
            throw new System.Exception("log factory 构造函数有错，没有创建LogFactory对象");
        }

        var response = logFactory.WriteLog(new ExceptionLog { LogException = ex });
        // Console.WriteLine(JsonConvert.SerializeObject(log));
        return response;
    }

    public LogResponse? Error(string logError)
    {
        var logFactory = ColaLogFactory.GetOdinLogUtils(EnumLogLevel.Info, Config, Service);
        if (logFactory == null)
        {
            throw new System.Exception("log factory 构造函数有错，没有创建LogFactory对象");
        }

        var response = logFactory.WriteLog(new ExceptionLog { LogException = new System.Exception(logError) });
        return response;
    }
}