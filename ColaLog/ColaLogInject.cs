using Cola.Core.ColaConsole;
using Cola.Core.Models.ColaLog;
using Cola.CoreUtils.Constants;
using Cola.CoreUtils.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaLog;

/// <summary>
///     ColaLogInject
/// </summary>
public static class ColaLogInject
{
    public static IServiceCollection AddColaLogs(
        this IServiceCollection services,
        IConfiguration config)
    {
        return AddSingletonColaLogs(services, config);
    }

    public static IServiceCollection AddSingletonColaLogs(
        this IServiceCollection services,
        IConfiguration config)
    {
        var logConfig = config.GetColaSection<LogConfig>(SystemConstant.CONSTANT_COLALOGS_SECTION);
        logConfig = logConfig ?? new LogConfig();
        var opts = new LogConfigOption { Config = logConfig };
        services.AddSingleton<IColaLogs>(provider => new ColaLogs(opts, services));
        ConsoleHelper.WriteInfo("注入类型【 IColaLogs, ColaLogs 】");
        return services;
    }
    
    public static IServiceCollection AddColaLogs(
        this IServiceCollection services,
        Action<LogConfigOption> action)
    {
        return AddSingletonColaLogs(services, action);
    }

    public static IServiceCollection AddSingletonColaLogs(
        this IServiceCollection services,
        Action<LogConfigOption> action)
    {
        var opts = new LogConfigOption();
        action(opts);
        services.AddSingleton<IColaLogs>(provider => new ColaLogs(opts, services));
        ConsoleHelper.WriteInfo("注入类型【 IColaLogs, ColaLogs 】");
        return services;
    }

    public static IServiceCollection AddTransientColaLogs(
        this IServiceCollection services,
        IConfiguration config)
    {
        var logConfig = config.GetColaSection<LogConfig>(SystemConstant.CONSTANT_COLALOGS_SECTION);
        var opts = new LogConfigOption { Config = logConfig };
        services.AddTransient<IColaLogs>(provider => new ColaLogs(opts, services));
        ConsoleHelper.WriteInfo("注入类型【 IColaLogs, ColaLogs 】");
        return services;
    }

    public static IServiceCollection AddTransientColaLogs(
        this IServiceCollection services,
        Action<LogConfigOption> action)
    {
        var opts = new LogConfigOption();
        action(opts);
        services.AddTransient<IColaLogs>(provider => new ColaLogs(opts, services));
        ConsoleHelper.WriteInfo("注入类型【 IColaLogs, ColaLogs 】");
        return services;
    }

    public static IServiceCollection AddScopedColaLogs(
        this IServiceCollection services,
        IConfiguration config)
    {
        var logConfig = config.GetColaSection<LogConfig>(SystemConstant.CONSTANT_COLALOGS_SECTION);
        var opts = new LogConfigOption { Config = logConfig };
        services.AddScoped<IColaLogs>(provider => new ColaLogs(opts, services));
        ConsoleHelper.WriteInfo("注入类型【 IColaLogs, ColaLogs 】");
        return services;
    }

    public static IServiceCollection AddScopedColaLogs(
        this IServiceCollection services,
        Action<LogConfigOption> action)
    {
        var opts = new LogConfigOption();
        action(opts);
        services.AddScoped<IColaLogs>(provider => new ColaLogs(opts, services));
        ConsoleHelper.WriteInfo("注入类型【 IColaLogs, ColaLogs 】");
        return services;
    }
}