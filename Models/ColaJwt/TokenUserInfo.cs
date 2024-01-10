namespace Cola.Core.Models.ColaJwt;

public class TokenUserInfo
{
    
    /// <summary>
    /// SysCurrentUserInfo
    /// </summary>
    public TokenUserInfo()
    {
    }

    public TokenUserInfo(string currentLoginName, string currentUserId, string currentUserName)
    {
        CurrentLoginName = currentLoginName;
        CurrentUserId = currentUserId;
        CurrentUserName = currentUserName;
    }

    /// <summary>
    /// CurrentLoginName
    /// </summary>
    public string CurrentLoginName { get; set; }
    /// <summary>
    /// CurrentUserId
    /// </summary>
    public string CurrentUserId { get; set; }
    /// <summary>
    /// CurrentUserName
    /// </summary>
    public string CurrentUserName { get; set; }

}