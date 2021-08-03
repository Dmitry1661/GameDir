using UnityEngine;

public class MBUnitController : MBGameObjectController
{
    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        GameLogic.UnitManager.Add(gameObject);
    }

    public MBGameLogic GameLogic { private set; get; }

    public CacheUnitAction CacheAction { set; get; }
    public CacheUnitCharacteristic CacheCharacteristic { set; get; }
}
