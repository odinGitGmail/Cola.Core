using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Config;
/// <summary>
/// NacosConfigInfo
/// </summary>
public class PublishNacosConfig
{
    /// <summary>
    /// 命名空间，默认为public与 ''相同
    /// </summary>
    [JsonProperty("namespaceId")]
    public string? NamespaceId { get; set; }
    
    /// <summary>
    /// 配置组名
    /// </summary>
    [JsonProperty("group")]
    [JsonRequired]
    public string Group { get; set; }
    
    /// <summary>
    /// 配置名
    /// </summary>
    [JsonProperty("dataId")]
    [JsonRequired]
    public string DataId { get; set; }
    
    /// <summary>
    /// 配置内容
    /// </summary>
    [JsonProperty("content")]
    [JsonRequired]
    public string Content { get; set; }
    
    /// <summary>
    /// 标签
    /// </summary>
    [JsonProperty("tag")]
    public string? Tag { get; set; }
    
    /// <summary>
    /// 应用名
    /// </summary>
    [JsonProperty("appName")]
    public string? AppName { get; set; }
    
    /// <summary>
    /// 源用户
    /// </summary>
    [JsonProperty("srcUser")]
    public string? SrcUser { get; set; }
    
    /// <summary>
    /// 配置标签列表，可多个，逗号分隔
    /// </summary>
    [JsonProperty("configTags")]
    public string? ConfigTags { get; set; }
    
    /// <summary>
    /// 配置描述
    /// </summary>
    [JsonProperty("desc")]
    public string? Desc { get; set; }
    
    /// <summary>
    /// use
    /// </summary>
    [JsonProperty("use")]
    public string? Use { get; set; }
    
    /// <summary>
    /// effect
    /// </summary>
    [JsonProperty("effect")]
    public string? Effect { get; set; }
    
    /// <summary>
    /// 配置类型
    /// </summary>
    [JsonProperty("type")]
    public string? ConfigType { get; set; }
    
    /// <summary>
    /// schema
    /// </summary>
    [JsonProperty("schema")]
    public string? Schema { get; set; }
}