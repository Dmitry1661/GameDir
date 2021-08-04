using UnityEngine;

/// <summary>
/// Горизонтальное перемещение Character.
/// </summary>
public class MBHorizontalMovement : MonoBehaviour
{
    public void ToLeft()
    {
        Movement(WatchDirectionEnum.Left);
    }
    public void ToRight()
    {
        Movement(WatchDirectionEnum.Right);
    }

    private void Movement(WatchDirectionEnum pWatchDirection)
    {
        // Герой должен быть в состонии ожидания.
        if (GameLogic.UnitManager.Character.CacheAction.ActionType.HasFlag(ActionType.None))
        {
            // Записываем в ActionCache что мы RUN
            GameLogic.UnitManager.Character.CacheAction = new CacheUnitAction(ActionType.Run);

            // Запускаем анимацию.
            GameLogic.UnitManager.Character.Animator.SetAnim(AnimationData.RUN, true);

            // Если смотрим в право, но поварачиваемся в лево.
            if (GameLogic.UnitManager.Character.Direction.WatchDirection.HasFlag(WatchDirectionEnum.Right) && 
                pWatchDirection.HasFlag(WatchDirectionEnum.Left))
            {
                // То развернем обьект.
                GameLogic.UnitManager.Character.Rotation.Rotation();

                // Перевернем скорость.
                GameLogic.UnitManager.Character.CacheCharacteristic =
                    new MoveSpeedInvolution(GameLogic.UnitManager.Character.CacheCharacteristic).Result;
            } 
            // Если смотрим в лево, но поварачиваемся в право.
            else if (GameLogic.UnitManager.Character.Direction.WatchDirection.HasFlag(WatchDirectionEnum.Left) &&
                pWatchDirection.HasFlag(WatchDirectionEnum.Right))
            {
                GameLogic.UnitManager.Character.Rotation.Rotation();

                GameLogic.UnitManager.Character.CacheCharacteristic =
                    new MoveSpeedInvolution(GameLogic.UnitManager.Character.CacheCharacteristic).Result;
            }
        }
    }

    public void ToStop()
    {
        GameLogic.UnitManager.Character.CacheAction = new CacheUnitAction(ActionType.None);

        GameLogic.UnitManager.Character.Animator.SetAnim(AnimationData.RUN, false);
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public MBGameLogic GameLogic { private set; get; }
}
