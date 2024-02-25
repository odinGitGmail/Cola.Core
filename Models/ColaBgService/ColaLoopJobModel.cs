namespace Cola.Core.Models.ColaBgServiceModels;
/// <summary>
/// ColaLoopJobModel
/// </summary>
public class ColaLoopJobModel : ColaJobModel
{
    public Action<CancellationToken>? StartAsyncAction { get; set; }
    public Action<CancellationToken>? ExecuteAsyncAction { get; set; }
}