using Cola.Core.ColaConsole;
using Cola.Core.ColaException;
using Microsoft.Extensions.DependencyInjection;

namespace Cola.Core;

public static class ColaCoreInject
{
    public static IServiceCollection AddColaCore(this IServiceCollection services)
    {
        services.AddSingleton<IColaException, ColaException.ColaException>();
        ConsoleHelper.WriteInfo("注入类型【 IColaException, ColaException 】");
        return services;
    }
}