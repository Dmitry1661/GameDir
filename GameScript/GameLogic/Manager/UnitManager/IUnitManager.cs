using System.Collections.Generic;
using UnityEngine;

public interface IUnitManager
{
    /// <summary>
    /// Метод принимает GameObject, читает его тег.В зависимости от результата сохраняет его.
    /// </summary>
    /// <param name="pObj">GameObject(Character or Enemy or NeutralHeroes)</param>
    void Add(GameObject pObj);

    /// <summary>
    /// Хранит ссылку на Character.
    /// </summary>
    MBCharacterController Character { get; }

    /// <summary>
    /// Хранит список ссылок на Enemies.
    /// </summary>
    List<MBEnemyController> EnemyList { get; }

    /// <summary>
    /// Хранит список ссылок на Неитральных персонажей.
    /// </summary>
    List<MBNeutralHeroesController> NeutralHeroesList { get; }
}
