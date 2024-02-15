using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Namespace.Service;

public class NacosServiceCreate
{
    /// <summary>
    /// 命名空间Id，默认为public
    /// </summary>
    [JsonProperty("namespaceId")]
    public string NamespaceId { get; set; } = "public";

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
    public string ServiceName { get; set; }

    /// <summary>
    /// 服务元数据，默认为空
    /// </summary>
    [JsonProperty("metadata")]
    public string Metadata { get; set; } = "";

    /// <summary>
    /// 是否为临时实例，默认为false
    /// </summary>
    [JsonProperty("ephemeral")]
    public bool Ephemeral { get; set; } = false;
    
    /// <summary>
    /// 保护阈值，默认为0
    /// </summary>
    [JsonProperty("protectThreshold")]
    public float ProtectThreshold { get; set; } = 0;
    
    /// <summary>
    /// 访问策略，默认为空
    /// </summary>
    [JsonProperty("selector")]
    public string Selector { get; set; } = "";
}