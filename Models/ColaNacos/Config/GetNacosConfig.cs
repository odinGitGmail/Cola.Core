using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Config;

public class GetNacosConfig
{
    /// <summary>
    /// 命名空间，默认为public与 ''相同
    /// </summary>
    [JsonProperty("namespaceId")]
    public string? NamespaceId { get; set; }
    
    /// <summary>
    /// 配置组名
    /// </summary>
    [JsonProperty("group")]
    [JsonRequired]
    public string? Group { get; set; }
    
    /// <summary>
    /// 配置名
    /// </summary>
    [JsonProperty("dataId")]
    [JsonRequired]
    public string? DataId { get; set; }
    
    /// <summary>
    /// 标签
    /// </summary>
    [JsonProperty("tag")]
    public string? Tag { get; set; }
}