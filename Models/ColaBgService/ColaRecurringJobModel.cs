namespace Cola.Core.Models.ColaBgServiceModels
{
    public class ColaRecurringJobModel : ColaJobModel
    {
        public Action<CancellationToken>? StartAsyncAction { get; set; }
        public new Action<object>? ExecuteAsyncAction { get; set; }
        /// <summary>
        /// 间隔时间 ms
        /// </summary>
        /// <value></value>
        public TimeSpan Period { get; set; }
        
        /// <summary>
        /// 延迟时间
        /// </summary>
        public TimeSpan DueTime { get; set; }
        public Object? State { get; set; }
        public Action<CancellationToken>? StopAsyncAction { get; set; }
    }
}