using UnityEngine;

public class MBUnitCollision : MBCollision
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.collider.name)
        {
            /*
            case CollisionData.FLOOR:

                //Если коснулись земли, то прыжок закончился.
                GameLogic.UnitManager.Character.Property
                    .Write(new ActionControll(), new string[] { ActionControllData.LOWER_THE_FLAG, "JUMP" });

                break;
            */
        }
    }
}
