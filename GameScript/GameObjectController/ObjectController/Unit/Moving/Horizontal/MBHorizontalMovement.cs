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
        // Записываем в ActionCache что мы RUN
        GameLogic.UnitManager.Character.Action.
            Input(new ActionControll(), new string[] { ActionControllData.UPPER_THE_FLAG, "RUN" });

        // Запускаем анимацию.
        GameLogic.UnitManager.Character.Animator.SetAnim(AnimationData.RUN, true);

        // Если смотрим в право, но поварачиваемся в лево.
        if (GameLogic.UnitManager.Character.Direction.WatchDirection.HasFlag(WatchDirectionEnum.Right) &&
            pWatchDirection.HasFlag(WatchDirectionEnum.Left))
        {
            // То развернем обьект.
            GameLogic.UnitManager.Character.Rotation.Rotation();

            // Перевернем скорость.
            GameLogic.UnitManager.Character.Property.Input(new InvolutionMoveSpeed());
        }
        // Если смотрим в лево, но поварачиваемся в право.
        else if (GameLogic.UnitManager.Character.Direction.WatchDirection.HasFlag(WatchDirectionEnum.Left) &&
            pWatchDirection.HasFlag(WatchDirectionEnum.Right))
        {
            GameLogic.UnitManager.Character.Rotation.Rotation();

            // Перевернем скорость.
            GameLogic.UnitManager.Character.Property.Input(new InvolutionMoveSpeed());
        }
    }

    public void ToStop()
    {
        GameLogic.UnitManager.Character.Action
            .Input(new ActionControll(), new string[] { ActionControllData.LOWER_THE_FLAG, "RUN" });

        GameLogic.UnitManager.Character.Animator.SetAnim(AnimationData.RUN, false);
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public MBGameLogic GameLogic { private set; get; }
}
