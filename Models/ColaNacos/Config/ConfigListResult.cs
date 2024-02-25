using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Config;

/// <summary>
/// 查询指定命名空间下的配置列表 - 返回数据
/// </summary>
public class ConfigListResult
{
    /// <summary>
    /// 配置id
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }
    
    /// <summary>
    /// 配置名
    /// </summary>
    [JsonProperty("dataId")]
    public string? DataId { get; set; }
    
    /// <summary>
    /// 配置分组
    /// </summary>
    [JsonProperty("group")]
    public string? Group { get; set; }
    
    /// <summary>
    /// 配置内容
    /// </summary>
    [JsonProperty("content")]
    public string? Content { get; set; }
    
    /// <summary>
    /// 配置内容的md5值
    /// </summary>
    [JsonProperty("md5")]
    public string? Md5 { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("encryptedDataKey")]
    public string? EncryptedDataKey { get; set; }
    
    /// <summary>
    /// 租户信息（命名空间）
    /// </summary>
    [JsonProperty("tenant")]
    public string? Tenant { get; set; }
    
    /// <summary>
    /// 应用名
    /// </summary>
    [JsonProperty("appName")]
    public string? AppName { get; set; }
    
    /// <summary>
    /// 配置文件类型
    /// </summary>
    [JsonProperty("type")]
    public string? ConfigType { get; set; }
    
    /// <summary>
    /// 上次修改时间
    /// </summary>
    [JsonProperty("lastModified")]
    public long LastModified { get; set; }
}