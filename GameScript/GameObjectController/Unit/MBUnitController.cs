using UnityEngine;

/************************************************************************************************************/
/*********************************************** UNIT_CONTROLLER ********************************************/
/************************************************************************************************************/
/*********Наследуемые классы требуют пристального наблюдения и КЕШ для хранения переменых значений.**********/
/************************************************************************************************************/
public class MBUnitController : MBGameObjectController
{
    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        if (GameLogic.UnitManager == null)
        {
            print("NULL");
        }

        GameLogic.UnitManager.Add(gameObject);


        //Переделать
        CacheCharacteristic = new CacheUnitCharacteristic(CacheUnitData.DEFAULT_ATTACK_POWER, 
                                                       CacheUnitData.DEFAULT_ATTACK_SPEED,
                                                       CacheUnitData.DEFAULT_MOVE_SPEED);
    }

    public MBGameLogic GameLogic { private set; get; }

    public CacheUnitAction CacheAction;
    public CacheUnitCharacteristic CacheCharacteristic;
}
