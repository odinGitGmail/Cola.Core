using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos;

public class NacosNamespaceInfo : NacosNamespaceLst
{
    /// <summary>
    /// 命名空间的容量
    /// </summary>
    [JsonProperty("quota")]
    public int Quota { get; set; }
    
    /// <summary>
    /// 命名空间下的配置数量
    /// </summary>
    [JsonProperty("configCount")]
    public int ConfigCount { get; set; }
    
    /// <summary>
    /// 命名空间类型  命名空间分为3种类型，0 - 全局命名空间 1 - 默认私有命名空间 2 - 自定义命名空间
    /// <code>
    /// 命名空间分为3种类型
    /// 0 - 全局命名空间
    /// 1 - 默认私有命名空间
    /// 2 - 自定义命名空间
    /// </code>
    /// </summary>
    [JsonProperty("type")]
    public int NamespaceType { get; set; }
}