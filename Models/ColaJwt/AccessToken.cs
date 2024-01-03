namespace Cola.Core.Models.ColaJwt;

public class AccessToken
{
    public string Token { get; set; }
    public string TokenType { get; set; } = "Bearer";

    public int ExpiresIn { get; set; }
}