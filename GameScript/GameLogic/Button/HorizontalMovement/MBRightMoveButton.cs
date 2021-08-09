﻿using UnityEngine;
using UnityEngine.EventSystems;

/************************************************************************************************************/
/********************************************>>>_RIGHT_MOVE_BUTTON_>>>***************************************/
/************************************************************************************************************/
/***************Скрипт обрабатывает UI.Button отвечающую за перемещение UnitCharacter вправо.****************/
/************************************************************************************************************/
public class MBRightMoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IHorizontalMovement
{
    public void OnPointerDown(PointerEventData eventData)
    {
        HorizontalMovement.ToRight();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        HorizontalMovement.ToStop();
    }

    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();

        if((HorizontalMovement = GameLogic.UnitManager.Character.GameObj.GetComponent<MBHorizontalMovement>()) == null)
            Debug.Log($"Подключите к обьекту {GameLogic.UnitManager.Character.GameObj.name} скрипт {ObjectControllerData.HorizontalMovement}.");
    }

    public MBGameLogic GameLogic { private set; get; }
    public MBHorizontalMovement HorizontalMovement { private set; get; }
}
