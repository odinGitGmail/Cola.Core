using Cola.Core.ColaConsole;
using Cola.Core.ColaEx;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core;

public static class ColaCoreInject
{
    public static IServiceCollection AddColaException(this IServiceCollection services)
    {
        services.AddSingleton<IColaException, ColaException>();
        ConsoleHelper.WriteInfo("注入类型【 IColaException, ColaException 】");
        return services;
    }
}