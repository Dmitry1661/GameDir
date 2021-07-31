using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Информационое ядро игры.
/// Данный скипт висит на DontDestroy сцене и доступен отовсюду.
/// </summary>
public class MBGameDir : MonoBehaviour
{
    public void Start()
    {
        ConstructorMissionManager();
    }

    private void ConstructorMissionManager()
    {
        List<Mission> missionList = new List<Mission>();

        for (int i = 0; i < MissionData.MISSION_COUNT; ++i)
        {
            missionList.Add(MBLoadMission.Get($"{MissionData.MISSION_PATH + (i + 1)}/{MissionData.MISSION_FILE_NAME}"));
        }

        MissionManager = new MissionManager(missionList);
    }

    public MissionManager MissionManager { private set; get; }
}
