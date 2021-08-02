using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс для загрузки Mission.
/// </summary>
public class MBLoadMission : MonoBehaviour
{
    /// <summary>
    /// Создать список Mission из JSON.
    /// </summary>
    /// <param name="pPathToDirectory">Пусть до директории.</param>
    /// <param name="pNameFile">Имя файла.</param>
    public static List<Mission> Get(string pPathToDirectory, string pNameFile)
    {
        List<Mission> missionList = new List<Mission>();

        for (int i = 0; i < MissionData.MISSION_COUNT; ++i)
        {
            missionList.Add(MBLoadMission.LoadMission($"{pPathToDirectory + (i + 1)}/{pNameFile}"));
        }

        return missionList;
    }

    private static Mission LoadMission(string pPath)
    {
        return JsonUtility.FromJson<Mission>(MBTextFileOpen.Read(pPath));
    }
}
