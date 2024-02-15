using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Namespace.Service;

public class NacosService
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
}