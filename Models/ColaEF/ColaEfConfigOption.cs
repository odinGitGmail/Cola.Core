namespace Cola.Core.Models.ColaEF;

public class ColaEfConfigOption
{
    public string TenantResolutionStrategy { get; set; } = "NoTenant";
    public List<ColaEfConfig>? ColaOrmConfig { get; set; }
}