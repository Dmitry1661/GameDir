using UnityEngine;
using UnityEngine.EventSystems;

public class MBLeftMoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        if (GameLogic.GameDir.PlayerManager.CacheAction.ActionType.HasFlag(ActionType.None))
        {
            GameLogic.GameDir.PlayerManager.SetAction(ActionType.Run);

            GameLogic.UnitManager.Character.Animator.SetAnim(AnimationData.RUN, true);

            GameLogic.UnitManager.Character.Rotation.
                Rotation(GameLogic.UnitManager.Character.Direction.WatchDirection.HasFlag(WatchDirectionEnum.Left));
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (GameLogic.GameDir.PlayerManager.CacheAction.ActionType.HasFlag(ActionType.Run))
        {
            GameLogic.GameDir.PlayerManager.SetAction(ActionType.None);

            GameLogic.UnitManager.Character.Animator.SetAnim(AnimationData.RUN, false);
        }
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public MBGameLogic GameLogic { private set; get; }
}
