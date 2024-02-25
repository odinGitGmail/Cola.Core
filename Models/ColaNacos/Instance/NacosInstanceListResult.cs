using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Cola.Core.Models.ColaNacos.Instance;

public class NacosInstanceListResult
{
    /// <summary>
    /// 分组名@@服务名
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }
    
    /// <summary>
    /// 分组名
    /// </summary>
    [JsonProperty("groupName")]
    public string? GroupName { get; set; }
    
    /// <summary>
    /// 集群名
    /// </summary>
    [JsonProperty("clusters")]
    public string? Clusters { get; set; }

    /// <summary>
    /// 缓存时间
    /// </summary>
    [JsonProperty("cacheMillis")]
    [Required]
    public int CacheMillis { get; set; }
    
    /// <summary>
    /// IP地址，默认为空，表示不限制IP地址
    /// </summary>
    [JsonProperty("hosts")]
    public NacosInstanceResultHost[]? Hosts { get; set; }

    /// <summary>
    /// 上次刷新时间
    /// </summary>
    [JsonProperty("lastRefTime")]
    public long LastRefTime { get; set; }
    
    /// <summary>
    /// 校验码
    /// </summary>
    [JsonProperty("checksum")]
    public string? Checksum { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("allIPs")]
    public bool AllIPs { get; set; }
    
    /// <summary>
    /// 是否到达保护阈值
    /// </summary>
    [JsonProperty("reachProtectionThreshold")]
    public bool ReachProtectionThreshold { get; set; }
    
    /// <summary>
    /// 是否有效
    /// </summary>
    [JsonProperty("valid")]
    public bool Valid { get; set; }
}