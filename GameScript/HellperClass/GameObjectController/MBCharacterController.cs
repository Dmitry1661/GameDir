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

        if (GameLogic.UnitManager.Character.CacheAction.ActionType.HasFlag(ActionType.Run))
        {
            GameLogic.UnitManager.Character.Position.NextPosition(
                    new NextPositionX(GameLogic.UnitManager.Character.Position.Transform.position,
                                      Time.fixedDeltaTime,
                                      GameLogic.UnitManager.Character.CacheCharacteristic.CurrentMoveSpeed).ResultPosition
                );
        }

        #endregion
    }
}
