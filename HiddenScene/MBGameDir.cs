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

        //PlayerManager = new PlayerManager(MBLoadPlayer.Get(PlayerData.PLAYER_SAVE));
        PlayerManager = new PlayerManager();
    }

    public PlayerManager PlayerManager { private set; get; }
    public MissionManager MissionManager { private set; get; }
}
