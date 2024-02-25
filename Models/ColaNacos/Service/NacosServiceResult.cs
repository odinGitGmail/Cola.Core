using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Service;

public class NacosServiceResult
{
    /// <summary>
    /// 命名空间
    /// </summary>
    [JsonProperty("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// 分组名
    /// </summary>
    [JsonProperty("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// 服务名
    /// </summary>
    [JsonProperty("serviceName")]
    public string? ServiceName { get; set; }
    
    /// <summary>
    /// 集群信息
    /// </summary>
    [JsonProperty("clusterMap")]
    public Dictionary<string,string>? ClusterMap { get; set; }
    
    /// <summary>
    /// 服务元数据
    /// </summary>
    [JsonProperty("metadata")]
    public Dictionary<string,string>? Metadata { get; set; }
    
    /// <summary>
    /// 保护阈值
    /// </summary>
    [JsonProperty("protectThreshold")]
    public float ProtectThreshold { get; set; }
    
    /// <summary>
    /// 访问策略
    /// </summary>
    [JsonProperty("selector")]
    public Object? Selector { get; set; }
    
    /// <summary>
    /// 是否为临时实例
    /// </summary>
    [JsonProperty("ephemeral")]
    public bool Ephemeral { get; set; }
}