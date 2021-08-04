using System.Collections.Generic;
using UnityEngine;

/************************************************************************************************************/
/*****************************************]**[UNIT.MANAGER]**[***********************************************/
/************************************************************************************************************/
/***********В UnitManager хранятся все обьекты RigidBody которым требуется пристольный контроль.*************/
/*********************************************1)Character****************************************************/
/**********************************************2)Enemies*****************************************************/
/*******************************************3)NeutralHeroes**************************************************/
/************************************************************************************************************/

public class MBUnitManager : MonoBehaviour
{
    /// <summary>
    /// Метод принимает GameObject, читает его тег.В зависимости от результата сохраняет его.
    /// </summary>
    /// <param name="obj">GameObject(Character or Enemy or NeutralHeroes)</param>
    public void Add(GameObject obj)
    {
        switch (obj.tag)
        {
            case UnitData.CHARACTER_TAG_NAME:

                Character = obj.GetComponent<MBCharacterController>();

                break;

            case UnitData.ENEMY_TAG_NAME:

                EnemyList.Add(obj.GetComponent<MBEnemyController>());

                break;

            case UnitData.NEUTRAL_HEROES_TAG_NAME:

                NeutralHeroesList.Add(obj.GetComponent<MBNeutralHeroesController>());

                break;
        }
    }

    public List<MBEnemyController> EnemyList { private set; get; }
    public MBCharacterController Character { private set; get; }
    public List<MBNeutralHeroesController> NeutralHeroesList { private set; get; }
}
