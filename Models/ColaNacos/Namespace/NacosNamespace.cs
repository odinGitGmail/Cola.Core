using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Namespace;

public class NacosNamespace
{
    /// <summary>
    /// 命名空间ID
    /// </summary>
    [JsonProperty("namespaceId")]
    public string NamespaceId { get; set; }
    
    /// <summary>
    /// 命名空间名称
    /// </summary>
    [JsonProperty("namespaceName")]
    public string NamespaceName { get; set; }
    
    /// <summary>
    /// 命名空间描述
    /// </summary>
    [JsonProperty("namespaceDesc")]
    public string NamespaceDesc { get; set; }
}