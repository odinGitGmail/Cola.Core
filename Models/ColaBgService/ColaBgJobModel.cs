namespace Cola.Core.Models.ColaBgServiceModels
{
    public class ColaBgJobModel : ColaJobModel
    {
        public Action<CancellationToken>? StartAsyncAction { get; set; }
        public Action<CancellationToken>? ExecuteAsyncAction { get; set; }
        public Action<CancellationToken>? StopAsyncAction { get; set; }
    }
}