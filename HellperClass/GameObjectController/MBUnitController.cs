using UnityEngine;

public class MBUnitController : MBGameObjectController
{
    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        AddUnit();
    }

    public void AddUnit()
    {
        GameLogic.UnitManager.Add(gameObject);
    }

    public MBGameLogic GameLogic { private set; get; }
}
