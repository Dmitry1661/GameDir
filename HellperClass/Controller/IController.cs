﻿using UnityEngine;

/// <summary>
/// В данном классе все скрипты отвечающие за констроль обьекта(Направление, Позиция, Анимация.) и ссылка на него.
/// </summary>
public interface IController
{
    /// <summary>
    /// Хранится ссылка на обьект.
    /// </summary>
    GameObject CharacterObject { get; }

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
    MBAnimation Animation { get; }
}