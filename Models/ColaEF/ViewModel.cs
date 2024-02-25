namespace Cola.Core.Models.ColaEF;

/// <summary>
/// viewModel
/// </summary>
/// <typeparam name="T"></typeparam>
public class ViewModel<T>
{
    /// <summary>
    /// 当前页标
    /// </summary>
    public int TotalCount { get; set; } = 1;
    /// <summary>
    /// 当前页标
    /// </summary>
    public int CurrentPage { get; set; } = 1;
    /// <summary>
    /// 总页数
    /// </summary>
    public int PageCount { get; set; } = 6;
    /// <summary>
    /// 每页大小
    /// </summary>
    public int PageSize { set; get; }
    
    /// <summary>
    /// 返回数据
    /// </summary>
    public List<T>? Data { get; set; }
}