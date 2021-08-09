using UnityEngine;
using UnityEngine.EventSystems;

public class MBJumpButton : MonoBehaviour, IPointerClickHandler, IVerticalMovement
{
    public void OnPointerClick(PointerEventData eventData)
    {
        VerticalMovement.Jump();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        if ((VerticalMovement = GameLogic.UnitManager.Character.GameObj.GetComponent<MBVerticalMovement>()) == null)
            Debug.Log($"Подключите к обьекту {GameLogic.UnitManager.Character.GameObj.name} скрипт {ObjectControllerData.VerticalMovement}.");
    }

    public MBGameLogic GameLogic { private set; get; }
    public MBVerticalMovement VerticalMovement { private set; get; }
}
