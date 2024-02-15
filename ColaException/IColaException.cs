using Cola.CoreUtils.Enums;

namespace Cola.Core.ColaException;

public interface IColaException
{
    /// <summary>
    /// throw number>0
    /// </summary>
    /// <param name="i"></param>
    /// <param name="enumException"></param>
    /// <returns></returns>
    public Exception? ThrowGreaterThanZero(int i, EnumException enumException);

    /// <summary>
    /// object is null
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="enumException"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    Exception? ThrowIfNull<T>(T obj, EnumException enumException);
    
    /// <summary>
    /// throw String Is NullOrEmpty
    /// </summary>
    /// <param name="str"></param>
    /// <param name="enumException"></param>
    /// <returns></returns>
    Exception? ThrowStringIsNullOrEmpty(string str, EnumException enumException);
    
    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="enumException"></param>
    /// <returns></returns>
    Exception ThrowException(EnumException enumException);
    
    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    Exception ThrowException(Exception ex);
    
    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="exStr"></param>
    /// <returns></returns>
    Exception ThrowException(string exStr);
}