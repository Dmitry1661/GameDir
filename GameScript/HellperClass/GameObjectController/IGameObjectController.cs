﻿using UnityEngine;

/************************************************************************************************************/
/*******************************...[INTERFACE_GAME^OBJECT_CONTROLLER]...*************************************/
/************************************************************************************************************/
/*********** Классы реализующие данный интерфейс будут использоваться с обьектами RigidBody2D.***************/
/************************************************************************************************************/

public interface IGameObjectController
{
    /// <summary>
    /// Инициализация происходит через Awake.
    /// </summary>
    void Awake();

    /// <summary>
    /// Хранится ссылка на обьект.
    /// </summary>
    GameObject GameObj { get; }

    /// <summary>
    /// Устанавливает направление.
    /// </summary>
    MBDirection Direction { get; }

    /// <summary>
    /// Отвечает за позицию.
    /// </summary>
    MBTransform Position { get; }

    /// <summary>
    /// Отвечает за анимацию.
    /// </summary>
    MBAnimator Animator { get; }

    /// <summary>
    /// Отвечает за разворот.
    /// </summary>
    MBRotation Rotation { get; }
}