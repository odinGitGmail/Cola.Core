using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Namespace;

public class NacosNamespaceLst
{
    /// <summary>
    /// 命名空间ID
    /// </summary>
    [JsonProperty("namespace")]
    public string NamespaceId { get; set; }
    
    /// <summary>
    /// 命名空间名称
    /// </summary>
    [JsonProperty("namespaceShowName")]
    public string NamespaceShowName { get; set; }
    
    /// <summary>
    /// 命名空间描述
    /// </summary>
    [JsonProperty("namespaceDesc")]
    public string NamespaceDesc { get; set; }
}