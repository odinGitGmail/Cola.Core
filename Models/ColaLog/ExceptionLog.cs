namespace Cola.Core.Models.ColaLog;

public class ExceptionLog : LogInfo
{
    public System.Exception? LogException { get; set; }
}