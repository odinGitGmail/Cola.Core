namespace Cola.Core.Models.ColaNacos;

/// <summary>
/// ColaNacosOption
/// </summary>
public class ColaNacosOption
{
    public string EndPoint { get; set; } = "";
    public List<NacosListenerOption>? Listeners { get; set; }
    public List<string>? ServerAddresses { get; set; }
    public string Namespace { get; set; } = "";
    public bool ConfigUseRpc { get; set; } = false;
    public bool NamingUseRpc { get; set; } = false;
    public string? Description { get; set; }
    
}