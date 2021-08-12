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

        if (GameLogic.UnitManager.Character.Action.Output().Current.HasFlag(ActionType.Run))
        {
            GameLogic.UnitManager.Character.Transform.NextPosition(
                    new StepPositionX(GameLogic.UnitManager.Character.Transform.Position,
                                      Time.fixedDeltaTime,
                                      GameLogic.UnitManager.Character.Property.Output(PropertyData.MOVE_SPEED).Current).ResultPosition
                );
        }

        #endregion

    }

    public void Update()
    {
    }
}
