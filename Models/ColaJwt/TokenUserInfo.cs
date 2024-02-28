namespace Cola.Core.Models.ColaJwt;

public class TokenUserInfo
{
    
    /// <summary>
    /// SysCurrentUserInfo
    /// </summary>
    public TokenUserInfo()
    {
    }

    public TokenUserInfo(string currentUserId)
    {
        CurrentUserId = currentUserId;
    }
    /// <summary>
    /// CurrentUserId
    /// </summary>
    public string? CurrentUserId { get; set; }

}