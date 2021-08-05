using UnityEngine;

/************************************************************************************************************/
/*********************************************** UNIT_CONTROLLER ********************************************/
/************************************************************************************************************/
/**********Родительские классы требуют пристального наблюдения и КЕШ для хранения переменых значений.********/
/************************************************************************************************************/
public class MBUnitController : MBGameObjectController
{
    public TextAsset SettingFileJson;

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        // Добавим обьект в UnitManager.
        GameLogic.UnitManager.Add(gameObject);

        // Настроим базовые характеристики Unit'a.
        if (SettingFileJson != null)
            CacheCharacteristic = new CacheUnitCharacteristic(JsonUtility.FromJson<UnitSetting>(SettingFileJson.text));
        else
            Debug.Log($"Подключите файл SettingFileJSON к обьекту {gameObject.name}");

    }

    public MBGameLogic GameLogic { private set; get; }

    public CacheUnitAction CacheAction;
    public CacheUnitCharacteristic CacheCharacteristic;
}
