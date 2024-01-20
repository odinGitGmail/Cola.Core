using Cola.Core.Models.ColaJwt;
using Newtonsoft.Json;

namespace Cola.Core.Models;

/// <summary>
///     方法返回类型
/// </summary>
/// <typeparam name="T">Data 泛型类型</typeparam>
public class ApiResult<T>
{
    /// <summary>
    /// 错误码，0代表执行成功，非0代表执行失败的某一种情况
    /// </summary>
    [JsonProperty("code")]
    public int Code { get; set; }
    
    /// <summary>
    /// 错误码提示信息，执行成功为”success”
    /// </summary>
    [JsonProperty("message")]
    public string Message { get; set; }
    
    /// <summary>
    /// 返回数据，执行失败时为详细出错信息
    /// </summary>
    [JsonProperty("data")]
    public T Data { get; set; }
    
    /// <summary>
    /// Token
    /// </summary>
    [JsonProperty("token")]
    public AccessToken? Token { get; set; }
}