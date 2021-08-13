using UnityEngine;

public class MBVerticalMovement : MonoBehaviour
{
    public void Jump()
    {
        // Проверяем что бы количесво прыжков не привышало максимально разрешенное.
        /*
        if (GameLogic.UnitManager.Character.Property.CountJump.Current >= 
            GameLogic.UnitManager.Character.Property.CountJump.Intermediate) return;
        */

        /*
        // Выставим текущее дейсвие Jump.
        GameLogic.UnitManager.Character.UnitDataBuffer.CacheAction.ActionType |= ActionType.Jump;

        // Установим совершенное количесво прыжков.

        GameLogic.UnitManager.Character.Transform.Rigidbody.AddForce(new Vector3(0f, 10f , 0f) , ForceMode2D.Impulse);
        */
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public MBGameLogic GameLogic { private set; get; }
}
