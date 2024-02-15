using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Namespace.Service;

public class NacosServiceList
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
    /// 访问策略
    /// </summary>
    [JsonProperty("selector")]
    public string Selector { get; set; } = "{}";

    /// <summary>
    /// 当前页，默认为1
    /// </summary>
    [JsonProperty("pageNo")]
    public int PageNo { get; set; } = 1;
    
    /// <summary>
    /// 页条目数，默认为20，最大为500
    /// </summary>
    [JsonProperty("pageSize")]
    public int PageSize { get; set; } = 20;
}