using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Информационое ядро игры.
/// Данный скипт висит на DontDestroy сцене и его поля доступны отовлюду.
/// </summary>
public class MBGameDir : MonoBehaviour
{
    public void Start()
    {
        CreateMissionManager();
        CreatePlayerManager();
        CreateSaveManager();
    }

    private void CreateMissionManager()
    {
        MissionManager = new MissionManager(MBLoadMission.Get(MissionData.MISSION_PATH, MissionData.MISSION_FILE_NAME));
    }

    private void CreatePlayerManager()
    {
    }

    private void CreateSaveManager()
    {
    }


    public PlayerManager PlayerManager { private set; get; }
    public MissionManager MissionManager { private set; get; }
    public SaveManager SaveManager { private set; get; }
}
