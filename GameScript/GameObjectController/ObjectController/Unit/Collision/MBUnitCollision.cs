using UnityEngine;

public class MBUnitCollision : MBCollision
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.collider.name)
        {
            case CollisionData.FLOOR:

                //Если коснулись земли, то прыжок закончился.
                if(GameLogic.UnitManager.Character.UnitDataBuffer.CacheAction.ActionType.HasFlag(ActionType.Jump))
                    GameLogic.UnitManager.Character.UnitDataBuffer.CacheAction.ActionType ^= ActionType.Jump;

                //Сбрасываем счетчик прыжка.
                GameLogic.UnitManager.Character.UnitDataBuffer.CacheCharacteristic.CurrentNumberJump = 0;

                break;
        }
    }
}
