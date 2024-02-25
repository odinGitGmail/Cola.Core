using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Instance;

public class QueryNacosInstanceList : QueryNacosInstance
{
    /// <summary>
    /// 是否只获取健康实例，默认为false
    /// </summary>
    [JsonProperty("healthyOnly")]
    public bool HealthyOnly { get; set; } = false;
    
    /// <summary>
    /// 应用名，默认为空
    /// </summary>
    [JsonProperty("app")]
    public string? App { get; set; }
}