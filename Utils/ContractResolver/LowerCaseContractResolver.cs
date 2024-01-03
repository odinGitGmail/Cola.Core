using Newtonsoft.Json.Serialization;

namespace Cola.Core.Utils.ContractResolver;

public class LowerCaseContractResolver : DefaultContractResolver
{
    protected override string ResolvePropertyName(string propertyName)
    {
        return propertyName.ToLower();
    }
}