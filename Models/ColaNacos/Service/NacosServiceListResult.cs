using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Service;

public class NacosServiceListResult
{
    [JsonProperty("count")]
    public int Count { get; set; }
    
    [JsonProperty("services")]
    public List<string>? Services { get; set; }
}