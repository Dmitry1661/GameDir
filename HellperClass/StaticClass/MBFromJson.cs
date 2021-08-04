using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Клас для получения обьектов из JSON.
/// </summary>
public class MBFromJson<T> : MonoBehaviour
{
    /// <summary>
    /// Создает список <T> из JSON файлов. 
    /// </summary>
    /// <param name="pPathToDirectory">Пусть до директории.</param>
    /// <param name="pNameFile">Имя файла.</param>
    public static List<T> GetAll(string pPathToDirectory, string pNameFile)
    {
        List<T> missionList = new List<T>();

        for (int i = 0; i < MissionData.MISSION_COUNT; ++i)
        {
            missionList.Add(MBFromJson<T>.Get($"{pPathToDirectory + (i + 1)}/{pNameFile}"));
        }

        return missionList;
    }

    /// <summary>
    /// Создает обьект из JSON файла.
    /// </summary>
    /// <param name="pPath">Пусть до файла.</param>
    /// <returns></returns>
    public static T Get(string pPath)
    {
        return JsonUtility.FromJson<T>(MBTextFileOpen.Read(pPath));
    }
}
