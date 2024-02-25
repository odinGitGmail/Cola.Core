using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Instance;

public class NacosInstanceResultHost
{
    /// <summary>
    /// 实例IP
    /// </summary>
    [JsonProperty("ip")]
    public string? Ip { get; set; }

    /// <summary>
    /// 实例端口号
    /// </summary>
    [JsonProperty("port")]
    public int Port { get; set; }
    
    /// <summary>
    /// 实例端口号
    /// </summary>
    [JsonProperty("weight")]
    public double Weight { get; set; }
    
    /// <summary>
    /// 实例是否健康
    /// </summary>
    [JsonProperty("healthy")]
    public bool Healthy { get; set; }
    
    /// <summary>
    /// 实例是否可用
    /// </summary>
    [JsonProperty("enabled")]
    public bool Enabled { get; set; }
    
    /// <summary>
    /// 是否为临时实例
    /// </summary>
    [JsonProperty("ephemeral")]
    public bool Ephemeral { get; set; }
    
    /// <summary>
    /// 实例所在的集群名称
    /// </summary>
    [JsonProperty("clusterName")]
    public string? ClusterName { get; set; }
    
    /// <summary>
    /// 服务名
    /// </summary>
    [JsonProperty("serviceName")]
    public string? ServiceName { get; set; }
    
    /// <summary>
    /// 实例元数据
    /// </summary>
    [JsonProperty("metadata")]
    public dynamic? Metadata { get; set; }
    
    /// <summary>
    /// 实例心跳超时时间
    /// </summary>
    [JsonProperty("instanceHeartBeatTimeOut")]
    public int InstanceHeartBeatTimeOut { get; set; }
    
    /// <summary>
    /// 实例删除超时时间
    /// </summary>
    [JsonProperty("ipDeleteTimeout")]
    public int IpDeleteTimeout { get; set; }
    
    /// <summary>
    /// 实例心跳间隔
    /// </summary>
    [JsonProperty("instanceHeartBeatInterval")]
    public int InstanceHeartBeatInterval { get; set; }
    
}