using UnityEngine;
using UnityEngine.SceneManagement;

/************************************************************************************************************/
/*******************************************...Game[)irecector...********************************************/
/************************************************************************************************************/

public class MBGameDir : MonoBehaviour
{
    private void Initialize()
    {
        MissionManager = new MissionManager(MBFromJson<Mission>.GetMissionList(MissionData.MISSION_PATH, MissionData.MISSION_FILE_NAME));
    }

    private void StartingGame()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("GameScene");
    }

    public void Start()
    {
        Initialize();
        StartingGame();
    }

    public MissionManager MissionManager { private set; get; }
    public GameSetting Setting { private set; get; }
}
