using UnityEngine;
using UnityEngine.SceneManagement;

public class MBMenuLogic : MonoBehaviour
{
    public void Awake()
    {
        //***
        SceneManager.LoadScene("GameScene");
        //***

        GameDir = GameObject.Find(GameData.GAME_DIR).GetComponent<MBGameDir>();
    }

    public MBGameDir GameDir { private set; get; }
}
