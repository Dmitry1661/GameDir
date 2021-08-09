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
    public void Add(GameObject pObj)
    {
        switch (pObj.tag)
        {
            case UnitData.CHARACTER_TAG_NAME:

                Character = pObj.GetComponent<MBCharacterController>();

                break;

            case UnitData.ENEMY_TAG_NAME:

                EnemyList.Add(pObj.GetComponent<MBEnemyController>());

                break;

            case UnitData.NEUTRAL_HEROES_TAG_NAME:

                NeutralHeroesList.Add(pObj.GetComponent<MBNeutralHeroesController>());

                break;

            default:

                Debug.Log($"UnitManager:Тэг \"{pObj.tag}\" неизвестен. Обьект невозможно записать в UnitManager.");

                break;
        }
    }

    public MBCharacterController Character { private set; get; }
    public List<MBEnemyController> EnemyList { private set; get ; }
    public List<MBNeutralHeroesController> NeutralHeroesList { private set; get; }
}
