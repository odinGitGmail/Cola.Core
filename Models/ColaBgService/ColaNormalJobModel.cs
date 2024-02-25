namespace Cola.Core.Models.ColaBgServiceModels
{
    public class ColaNormalJobModel : ColaJobModel
    {
        public Action<CancellationToken>? StartAsyncAction { get; set; }
        public Action<CancellationToken>? StopAsyncAction { get; set; }
        
        public Action<CancellationToken>? NormalJobAction { get; set; }
    }
}