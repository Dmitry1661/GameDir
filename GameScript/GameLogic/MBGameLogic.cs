using UnityEngine;

public class MBGameLogic : MonoBehaviour
{
    public void Awake()
    {
        GameDir = GameObject.Find(Data.GAME_DIR).GetComponent<MBGameDir>();

        UnitManager = GameObject.Find(Data.GAME_LOGIC).GetComponent<MBUnitManager>();
        WorldManager = GameObject.Find(Data.GAME_LOGIC).GetComponent<MBWorldManager>();
    }

    public MBGameDir GameDir { private set; get; }
    public MBUnitManager UnitManager { private set; get; }
    public MBWorldManager WorldManager { private set; get; }
}
