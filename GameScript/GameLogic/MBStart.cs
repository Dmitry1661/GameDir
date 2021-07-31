using UnityEngine;

/// <summary>
/// Это стартовый скрипт. В его обьязаности входит:
/// 1)Создать Character.
/// 2)...
/// 3)...
/// </summary>
public class MBStart : MonoBehaviour
{
    public void Start()
    {
        GameLogic = GameObject.Find(Data.GAME_LOGIC).GetComponent<MBGameLogic>();

        CreatingWorld();
    }

    private void CreatingWorld()
    {
        GameObject obj = Instantiate(Resources.Load(GameLogic.GameDir.MissionManager.CurrentMission.CellName)) as GameObject;

        GameLogic.WorldManager.Add(obj);
    }

    public MBGameLogic GameLogic { private set; get; }
}
