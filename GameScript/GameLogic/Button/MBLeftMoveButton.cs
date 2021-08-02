using UnityEngine;
using UnityEngine.EventSystems;

public class MBLeftMoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public MBGameLogic GameLogic { private set; get; }
}
