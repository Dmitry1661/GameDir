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

        if ((VerticalMovement = GameLogic.UnitManager.Character.GameObj.GetComponent<MBVerticalMovement>()) == null)
            Debug.Log($"Подключите к обьекту {GameLogic.UnitManager.Character.GameObj.name} скрипт {ObjectControllerData.VerticalMovement}.");
    }

    public MBGameLogic GameLogic { private set; get; }
    public MBVerticalMovement VerticalMovement { private set; get; }
}
