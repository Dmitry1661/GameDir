using UnityEngine;

public class MBGameLogic : MonoBehaviour
{
    public void Awake()
    {
        GameDir = GameObject.Find(GameData.GAME_DIR).GetComponent<MBGameDir>();

        UnitManager = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBUnitManager>();
        WorldManager = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBWorldManager>();
    }

    public MBGameDir GameDir { private set; get; }
    public MBUnitManager UnitManager { private set; get; }
    public MBWorldManager WorldManager { private set; get; }
}
