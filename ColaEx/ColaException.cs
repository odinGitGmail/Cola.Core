using Cola.Core.ColaConsole;
using Cola.CoreUtils.Enums;
using Cola.CoreUtils.Extensions;

namespace Cola.Core.ColaEx;


public class ColaException : IColaException
{
    /// <summary>
    /// throw number>0
    /// </summary>
    /// <param name="i"></param>
    /// <param name="enumException"></param>
    /// <returns></returns>
    public Exception? ThrowGreaterThanZero(int i, EnumException enumException)
    {
        if (i > 0)
            return ThrowException(enumException);
        return null;
    }

    /// <summary>
    /// object is null
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="enumException"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Exception? ThrowIfNull<T>(T obj, EnumException enumException)
    {
        if (obj == null)
        {
            ThrowException(enumException);
        }

        return null;
    }

    /// <summary>
    /// throw String Is NullOrEmpty
    /// </summary>
    /// <param name="str"></param>
    /// <param name="enumException"></param>
    /// <returns></returns>
    public Exception? ThrowStringIsNullOrEmpty(string str, EnumException enumException)
    {
        if (str.StringIsNullOrEmpty())
            return ThrowException(enumException);
        return null;
    }

    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="enumException"></param>
    /// <returns></returns>
    public Exception ThrowException(EnumException enumException)
    {
        var ex = new Exception(enumException.GetDescription());
        ConsoleHelper.WriteException(ex);
        return ex;
    }

    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    public Exception ThrowException(Exception ex)
    {
        ConsoleHelper.WriteException(ex);
        return ex;
    }

    public Exception ThrowException(string exStr)
    {
        var ex = new Exception(exStr);
        ConsoleHelper.WriteException(ex);
        return ex;
    }
}