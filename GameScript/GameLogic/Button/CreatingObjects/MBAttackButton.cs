using UnityEngine;
using UnityEngine.EventSystems;

public class MBAttackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if (GameLogic.UnitManager.Character.UnitDataBuffer.CacheAction.ActionType.HasFlag(ActionType.Run)) return;

        GameLogic.UnitManager.Character.UnitDataBuffer
            .Write(new ActionControll(), new string[]{ ActionControllData.UPPER_THE_FLAG, "ATTACK" });
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (GameLogic.UnitManager.Character.UnitDataBuffer.CacheAction.ActionType.HasFlag(ActionType.Attack))
           GameLogic.UnitManager.Character.UnitDataBuffer
                .Write(new ActionControll(), new string[]{ ActionControllData.LOWER_THE_FLAG, "ATTACK" });
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public MBGameLogic GameLogic { private set; get; }
}
