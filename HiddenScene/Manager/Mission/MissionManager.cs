using System;
using System.Collections.Generic;

public class MissionManager
{
    public MissionManager(List<Mission> pMissionList)
    {
        MissionList = pMissionList;

        //CurrentMission = MissionList[Convert.ToInt32(MBPlayerPrefs.Load(MissionData.CURRENT_MISSION))];
    }

    /// <summary>
    /// Текущая последняя миссия.
    /// </summary>
    public Mission CurrentMission { private set; get; }

    /// <summary>
    /// Список всех миссий.
    /// </summary>
    public List<Mission> MissionList { private set; get; }
}
