using Cola.Core.ColaConsole;
using Cola.Core.ColaLog;

namespace Cola.Core.ColaException;


public class ColaException : IColaException
{
    /// <summary>
    /// throw number>0
    /// </summary>
    /// <param name="i"></param>
    /// <param name="errorMessage"></param>
    /// <returns></returns>
    public Exception? ThrowGreaterThanZero(int i, string errorMessage)
    {
        if (i > 0)
            return ThrowException(errorMessage);
        return null;
    }

    /// <summary>
    /// object is null
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="errorMessage"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public Exception? ThrowIfNull<T>(T obj, string errorMessage)
    {
        if (obj == null)
        {
            ThrowException($"{typeof(T).FullName} {errorMessage}");
        }

        return null;
    }

    /// <summary>
    /// throw String Is NullOrEmpty
    /// </summary>
    /// <param name="str"></param>
    /// <param name="exMessage"></param>
    /// <returns></returns>
    public Exception? ThrowStringIsNullOrEmpty(string str, string exMessage)
    {
        if (string.IsNullOrEmpty(str))
            return ThrowException($"{exMessage}");
        return null;
    }

    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public Exception ThrowException(string str)
    {
        var ex = new Exception(str);
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
}