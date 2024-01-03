using Newtonsoft.Json.Serialization;

namespace Cola.Core.Utils.ContractResolver;

public class NamingStrategyToLower : NamingStrategy
{
    protected override string ResolvePropertyName(string name)
    {
        return name.ToLower();
    }
}