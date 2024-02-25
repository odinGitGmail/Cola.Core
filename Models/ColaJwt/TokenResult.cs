namespace Cola.Core.Models.ColaJwt;

public class TokenResult
{
    public AccessToken? Token { get; set; }
    
    public RefreshToken? RefreshToken { get; set; }
}