using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Instance;

public class RegisterNacosInstance
{
    /// <summary>
    /// 命名空间ID
    /// </summary>
    [JsonProperty("namespaceId")]
    public string? NamespaceId { get; set; }
    
    /// <summary>
    /// 分组名，默认为DEFAULT_GROUP
    /// </summary>
    [JsonProperty("groupName")]
    public string GroupName { get; set; } = "DEFAULT_GROUP";

    /// <summary>
    /// 服务名
    /// </summary>
    [JsonProperty("serviceName")]
    [Required]
    public string? ServiceName { get; set; }
    
    /// <summary>
    /// IP地址
    /// </summary>
    [JsonProperty("ip")]
    [Required]
    public string? Ip { get; set; }
    
    /// <summary>
    /// 端口号
    /// </summary>
    [JsonProperty("port")]
    [Required]
    public int Port { get; set; }

    /// <summary>
    /// 集群名称，默认为DEFAULT
    /// </summary>
    [JsonProperty("clusterName")]
    public string ClusterName { get; set; } = "DEFAULT";
    
    /// <summary>
    /// 是否只获取健康实例，默认为false
    /// </summary>
    [JsonProperty("healthy")]
    public bool Healthy { get; set; } = true;
    
    /// <summary>
    /// 实例权重，默认为1.0
    /// </summary>
    [JsonProperty("weight")]
    public double Weight { get; set; } = 1.0;
    
    /// <summary>
    /// 是否可用，默认为true
    /// </summary>
    [JsonProperty("enabled")]
    public bool Enabled { get; set; } = true;
    
    /// <summary>
    /// 实例元数据
    /// </summary>
    [JsonProperty("metadata")]
    public dynamic? Metadata { get; set; }
    
    /// <summary>
    /// 是否为临时实例
    /// </summary>
    [JsonProperty("ephemeral")]
    public bool Ephemeral { get; set; } = false;
}