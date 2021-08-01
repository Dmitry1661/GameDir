using UnityEngine;

public class MBMenuLogic : MonoBehaviour
{
    public void Awake()
    {
        //SceneManager.LoadScene("GameScene");
        GameDir = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameDir>();
    }

    public MBGameDir GameDir { private set; get; }
}
