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
        GameObject obj = Instantiate(Resources.Load(GameLogic.GameDir.MissionManager.CurrentMission.CellName)) as GameObject;

        GameLogic.WorldManager.Add(obj);
    }

    public MBGameLogic GameLogic { private set; get; }
}
