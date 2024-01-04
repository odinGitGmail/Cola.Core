using Cola.CoreUtils.Enums;
using Cola.CoreUtils.Extensions;

namespace Cola.Core.Utils;

public class ColaExceptionUtils : System.Exception
{
    public ColaExceptionUtils(EnumException enumException) : base(enumException.GetDescription())
    {
    }

    public ColaExceptionUtils(EnumException enumException, string msg) : base(string.Format(enumException.GetDescription(), msg))
    {
    }

    public ColaExceptionUtils(string errorMessage) : base(errorMessage)
    {
    }
}