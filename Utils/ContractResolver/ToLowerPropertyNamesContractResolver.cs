using Newtonsoft.Json.Serialization;

namespace Cola.Core.Utils.ContractResolver;

public class ToLowerPropertyNamesContractResolver : DefaultContractResolver
{
    public ToLowerPropertyNamesContractResolver()
    {
        NamingStrategy = new NamingStrategyToLower();
    }
}