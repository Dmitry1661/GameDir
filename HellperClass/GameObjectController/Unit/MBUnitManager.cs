using System.Collections.Generic;
using UnityEngine;

public class MBUnitManager : MonoBehaviour
{
    /// <summary>
    /// Метод принимает GameObject, читает его тег.В зависимости от результата записывает либо в EnemyList, либо в Character.
    /// </summary>
    /// <param name="obj">GameObject(Character or Enemy)</param>
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
