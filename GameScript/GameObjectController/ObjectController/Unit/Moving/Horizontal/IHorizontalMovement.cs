﻿/************************************************************************************************************/
/****************************************.INTERFACE.HORIZONTAL.MOVEMENT.*************************************/
/************************************************************************************************************/
/*******************Данный интерфейс реализут горизонтальное перемещение unitCharacter.**********************/
/****************************************Подключается к UI.Button********************************************/
/************************************************************************************************************/
public interface IHorizontalMovement
{
    /// <summary>
    /// Данный скрипт необходимо подлючить к Character.
    /// </summary>
    MBHorizontalMovement HorizontalMovement { get; }
}