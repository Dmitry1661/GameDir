using UnityEngine;

/************************************************************************************************************/
/******************************************[CHARACTER_CONTROLLER]********************************************/
/************************************************************************************************************/
/*******************************Данный класс крепится к обьекту Character.***********************************/
/************************************************************************************************************/

public class MBCharacterController : MBUnitController
{
    public void FixedUpdate()
    {
        #region Перемещение персонажа по оси X

        if (GameLogic.UnitManager.Character.UnitDataBuffer.Action.ActionType.HasFlag(ActionType.Run))
        {
            GameLogic.UnitManager.Character.Transform.NextPosition(
                    new NextPositionX(GameLogic.UnitManager.Character.Transform.Position,
                                      Time.fixedDeltaTime,
                                      GameLogic.UnitManager.Character.UnitDataBuffer.MoveSpeed.Current).ResultPosition
                );
        }

        #endregion

    }

    public void Update()
    {
    }
}
