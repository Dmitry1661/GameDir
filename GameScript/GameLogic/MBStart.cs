using UnityEngine;

/// <summary>
/// Это стартовый скрипт. В его обьязаности входит:
/// 1)Создать Игровой уровень.
/// 2)...
/// 3)...
/// </summary>
public class MBStart : MonoBehaviour
{
    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        CreatingWorld();
    }

    private void CreatingWorld()
    {
        //GameObject obj = Instantiate(Resources.Load(GameLogic.GameDir.MissionManager.CurrentMission.CellName)) as GameObject;
        /*
        GameObject obj = Instantiate(Resources.Load("MissionFiles/Mission_1/CellDefault2")) as GameObject;

        GameLogic.WorldManager.Add(obj);
        */

        GameObject obj = Instantiate(Resources.Load("Character")) as GameObject;
    }

    public MBGameLogic GameLogic { private set; get; }
}
