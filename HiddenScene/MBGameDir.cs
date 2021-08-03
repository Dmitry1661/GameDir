using UnityEngine;

/// <summary>
/// Информационое ядро игры.
/// Данный скипт висит на DontDestroy сцене и его поля доступны отовлюду.
/// </summary>
public class MBGameDir : MonoBehaviour
{
    public void Start()
    {
        MissionManager = new MissionManager(MBLoadMission.GetAll(MissionData.MISSION_PATH, MissionData.MISSION_FILE_NAME));
    }

    public MissionManager MissionManager { private set; get; }
}
