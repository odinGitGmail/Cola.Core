using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Instance;

public class QueryNacosInstance
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
    /// 集群名称，默认为DEFAULT
    /// </summary>
    [JsonProperty("clusterName")]
    public string? ClusterName { get; set; }
    
    /// <summary>
    /// IP地址，默认为空，表示不限制IP地址
    /// </summary>
    [JsonProperty("ip")]
    [Required]
    public string? Ip { get; set; }

    /// <summary>
    /// 端口号，默认为0，表示不限制端口号
    /// </summary>
    [JsonProperty("port")]
    [Required]
    public int Port { get; set; } = 0;
}