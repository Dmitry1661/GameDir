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
        GameDir = GameObject.Find(GameData.GAME_DIR).GetComponent<MBGameDir>();

        UnitManager = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBUnitManager>();
        WorldManager = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBWorldManager>();

        Run();
    }

    /// <summary>
    /// Создать мир, мир создат всех юнитов и раставит их по своим позициям взависимости от условия миссии.
    /// </summary>
    private void Run()
    {
        GameObject obj = Instantiate(Resources.Load("Character")) as GameObject;
    }

    public MBGameDir GameDir { private set; get; }
    public MBUnitManager UnitManager { private set; get; }
    public MBWorldManager WorldManager { private set; get; }
}
