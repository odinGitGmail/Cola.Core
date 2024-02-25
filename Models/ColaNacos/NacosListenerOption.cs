namespace Cola.Core.Models.ColaNacos;

/// <summary>
/// NacosListenerOption
/// </summary>
public class NacosListenerOption
{
    public bool Optional { get; set; } = false;
    public string? DataId { get; set; }

    public string? Group { get; set; }
    public string? Description { get; set; }
}