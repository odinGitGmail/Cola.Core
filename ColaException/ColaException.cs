﻿using Cola.Core.ColaConsole;
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
    public System.Exception? ThrowGreaterThanZero(int i, string errorMessage)
    {
        if (i > 0)
            return ThrowException(errorMessage);
        return null;
    }
    
    /// <summary>
    /// object is null
    /// </summary>
    /// <param name="obj"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public System.Exception? ThrowIfNull<T>(T obj)
    {
        if (obj == null)
            return ThrowException($"{typeof(T).FullName} 参数不能为空");
        return null;
    }

    /// <summary>
    /// throw String Is NullOrEmpty
    /// </summary>
    /// <param name="str"></param>
    /// <param name="exMessage"></param>
    /// <returns></returns>
    public System.Exception? ThrowStringIsNullOrEmpty(string str, string exMessage)
    {
        if (string.IsNullOrEmpty(str))
            return ThrowException($"{exMessage} 不能为空");
        return null;
    }

    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public System.Exception ThrowException(string str)
    {
        var ex = new System.Exception(str);
        ConsoleHelper.WriteException((System.Exception)ex);
        return ex;
    }

    /// <summary>
    /// Throw Exception
    /// </summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    public System.Exception ThrowException(System.Exception ex)
    {
        ConsoleHelper.WriteException((System.Exception)ex);
        return ex;
    }
}