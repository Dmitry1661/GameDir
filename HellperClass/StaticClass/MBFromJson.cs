using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс для загрузки Mission.
/// </summary>
public class MBFromJson<T> : MonoBehaviour
{
    /// <summary>
    /// Создать список Mission из JSON.
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

    public static T Get(string pPath)
    {
        return JsonUtility.FromJson<T>(MBTextFileOpen.Read(pPath));
    }
}
