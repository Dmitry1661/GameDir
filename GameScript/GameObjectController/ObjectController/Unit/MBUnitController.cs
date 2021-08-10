using UnityEngine;

/************************************************************************************************************/
/*********************************************** UNIT_CONTROLLER ********************************************/
/************************************************************************************************************/
/**************Родительские классы требуют пристального наблюдения и Buffer для хранения Кэшев.**************/
/************************************************************************************************************/
public class MBUnitController : MBGameObjectController, IUnitController
{
    public TextAsset SettingFileJson;

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        // Добавим обьект в UnitManager.
        GameLogic.UnitManager.Add(gameObject);

        // Настроим базовые характеристики Unit'a.
        if (SettingFileJson != null)
            UnitDataBuffer = new DataBuffer(JsonUtility.FromJson<UnitSetting>(SettingFileJson.text));
        else
            Debug.Log($"Подключите файл SettingFileJSON к обьекту {gameObject.name}.");

        // Проверим подключeн ли скрипт отвечающий за колизию.
        if(gameObject.GetComponent<MBUnitCollision>() == null)
            Debug.Log($"Подключите скрипт отвичающий за колизию к обьету {gameObject.name}.");
    }

    public MBGameLogic GameLogic { private set; get; }
    public DataBuffer UnitDataBuffer { private set; get; }
}

