using UnityEngine;
using UnityEngine.EventSystems;

/************************************************************************************************************/
/*********************************************<<<_LEFT_MOVE_BUTTON_<<<***************************************/
/************************************************************************************************************/
/***************Скрипт обрабатывает UI.Button отвечающую за перемещение UnitCharacter влево.****************/
/************************************************************************************************************/
public class MBLeftMoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IHorizontalMovement
{
    public void OnPointerDown(PointerEventData eventData)
    {
        HorizontalMovement.ToLeft();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        HorizontalMovement.ToStop();
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        try
        {
            HorizontalMovement = GameLogic.UnitManager.Character.GameObj.GetComponent<MBHorizontalMovement>();
        }
        catch (MissingComponentException ex)
        { 
            MBLogMCE.Log(gameObject.name, ButtonData.LeftMoveButton, ex);
        }
    }

    public MBGameLogic GameLogic { private set; get; }
    public MBHorizontalMovement HorizontalMovement { private set; get; }
}
