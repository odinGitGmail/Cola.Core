using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Instance;

/// <summary>
/// NacosInstanceResult
/// </summary>
public class NacosInstanceResult
{
    /// <summary>
    /// 服务名
    /// </summary>
    [JsonProperty("serviceName")]
    public string? ServiceName { get; set; }
    
    /// <summary>
    /// IP地址
    /// </summary>
    [JsonProperty("ip")]
    public string? Ip { get; set; }
    
    /// <summary>
    /// 端口号
    /// </summary>
    [JsonProperty("port")]
    public int Port { get; set; }

    /// <summary>
    /// 集群名称
    /// </summary>
    [JsonProperty("clusterName")]
    [Required]
    public int ClusterName { get; set; }
    
    /// <summary>
    /// 实例权重
    /// </summary>
    [JsonProperty("weight")]
    public double Weight { get; set; }

    /// <summary>
    /// 是否健康
    /// </summary>
    [JsonProperty("healthy")]
    public bool Healthy { get; set; }
    
    /// <summary>
    /// 实例id
    /// </summary>
    [JsonProperty("instanceId")]
    public string? InstanceId { get; set; }
    
    /// <summary>
    /// 实例元数据
    /// </summary>
    [JsonProperty("metadata")]
    public dynamic? metadata { get; set; }
}