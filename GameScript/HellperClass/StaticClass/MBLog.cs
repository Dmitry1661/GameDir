using System;
using UnityEngine;

/// <summary>
/// Данный класс содержит один статичный метод, который выводит сообщение из исключения  MissingComponentException
/// </summary>
public class MBLogMCE : MonoBehaviour
{
    /// <summary>
    /// Выводит сообщение, в каком обьекте не подключон скрипт.
    /// </summary>
    /// <param name="pNameObject"></param>
    /// <param name="pNameScript"></param>
    public static void Log(string pNameObject, string pNameScript, Exception pException)
    {
        Debug.Log($"В обьекте \"{pNameObject}\" не подключон скрипт {pNameScript}.[{pException}]");
    }
}
