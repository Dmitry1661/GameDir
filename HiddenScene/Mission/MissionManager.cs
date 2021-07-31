using System.Collections.Generic;

public class MissionManager
{
    public MissionManager(List<Mission> pMissionList)
    {
        MissionList = pMissionList;
    }

    public Mission CurrentMission { private set; get; }
    public List<Mission> MissionList { private set; get; }
}
