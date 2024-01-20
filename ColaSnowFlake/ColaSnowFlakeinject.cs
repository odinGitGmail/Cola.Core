using Cola.Core.ColaConsole;
using Cola.Core.Models.ColaSnowFlake;
using Cola.Core.Utils;
using Cola.Core.Utils.Enums;
using Cola.CoreUtils.Constants;
using Cola.CoreUtils.Enums;
using Cola.CoreUtils.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core.ColaSnowFlake;

public  static class ColaSnowFlakeinject
{
    /// <summary>
    /// AddColaJwt
    /// </summary>
    /// <param name="services"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    public static IServiceCollection AddSingletonSnowFlake(
        this IServiceCollection services,
        Action<SnowFlakeConfigOption> action)
    {
        ConsoleHelper.WriteInfo("注入【 SnowFlake 】");
        var snowFlakeConfig = new SnowFlakeConfigOption();
        action(snowFlakeConfig);
        if (snowFlakeConfig == null || snowFlakeConfig.SnowFlakeConfig == null)
        {
            throw new ColaExceptionUtils(EnumException.SnowFlakeInjectConfigIsNull);
        }

        return services.AddSingleton<IColaSnowFlake>(provider => new ColaSnowFlake(new SnowFlakeModel()
        {
            DatacenterId = snowFlakeConfig.SnowFlakeConfig!.DatacenterId,
            WorkerId = snowFlakeConfig.SnowFlakeConfig.WorkerId,
        }));
    }
    
    /// <summary>
    /// AddColaJwt
    /// </summary>
    /// <param name="services"></param>
    /// <param name="config"></param>
    /// <returns></returns>
    public static IServiceCollection AddSingletonSnowFlake(
        this IServiceCollection services,
        IConfiguration config)
    {
        ConsoleHelper.WriteInfo("注入【 SnowFlake 】");
        var snowFlakeConfig = config.GetColaSection<SnowFlakeConfig>(SystemConstant.CONSTANT_COLASNOWFLAKE_SECTION);
        snowFlakeConfig = snowFlakeConfig ?? new SnowFlakeConfig();
        return services.AddSingleton<IColaSnowFlake>(provider => new ColaSnowFlake(new SnowFlakeModel()
        {
            DatacenterId = snowFlakeConfig.DatacenterId,
            WorkerId = snowFlakeConfig.WorkerId,
        }));
    }
}