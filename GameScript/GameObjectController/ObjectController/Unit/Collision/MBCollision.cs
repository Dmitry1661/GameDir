using UnityEngine;

public class MBCollision : MonoBehaviour, ICollision
{
    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public MBGameLogic GameLogic { private set; get; }
}
