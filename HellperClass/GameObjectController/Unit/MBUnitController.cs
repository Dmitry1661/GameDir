using UnityEngine;

public class MBUnitController : MBGameObjectController
{
    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        GameLogic.UnitManager.Add(gameObject);


        //Переделать
        CacheCharacteristic = new CacheUnitCharacteristic(CacheUnitData.DEFAULT_ATTACK_POWER, 
                                                       CacheUnitData.DEFAULT_ATTACK_SPEED,
                                                       CacheUnitData.DEFAULT_MOVE_SPEED);
    }

    public MBGameLogic GameLogic { private set; get; }

    public CacheUnitAction CacheAction { set; get; }
    public CacheUnitCharacteristic CacheCharacteristic { set; get; }
}
