using UnityEngine;


/************************************************************************************************************/
/*********************************************...][GAME.LOGIC][...*******************************************/
/************************************************************************************************************/
/**-Данный скрипт крепится к обьекту GameLogic, так же на этом обьекте должны быть закреплены все скрипты ***/
/**которые будут проинициализированы сдесь.******************************************************************/
/************************************************************************************************************/


public class MBGameLogic : MonoBehaviour
{
    public void Awake()
    {
        if ((GameDir = GameObject.Find(GameData.GAME_DIR).GetComponent<MBGameDir>()) == null)
            Debug.Log($"Подключите к обьекту {GameData.GAME_DIR} скрипт {GameData.GAME_DIR}.");

        if ((UnitManager = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBUnitManager>()) == null)
            Debug.Log($"Подключите к обьекту {GameData.GAME_LOGIC} скрипт {ManagerData.UnitManager}.");

        if((WorldManager = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBWorldManager>()) == null)
            Debug.Log($"Подключите к обьекту {GameData.GAME_LOGIC} скрипт {ManagerData.WorldManager}.");

        Run();
    }

    /// <summary>
    /// Создать мир, мир создат всех юнитов и раставит их по своим позициям взависимости от условия миссии.
    /// </summary>
    private void Run()
    {
        Instantiate(Resources.Load("Character"));
    }

    public MBGameDir GameDir { private set; get; }
    public MBUnitManager UnitManager { private set; get; }
    public MBWorldManager WorldManager { private set; get; }
}
