using UnityEngine;

/************************************************************************************************************/
/***************************************** >~]GameObjectController]~> ***************************************/
/************************************************************************************************************/
/*******Класс крепится к обьектy которому не трубуется пристальное наблюдение, он живет сам по себе.*********/
/************************************************************************************************************/

public class MBGameObjectController : MonoBehaviour, IGameObjectController
{
    public void Awake()
    {
        GameObj = gameObject;

        if ((Direction = gameObject.GetComponent<MBDirection>()) == null) 
            Debug.Log($"Подключите к обьекту {gameObject.name} скрипт {ObjectControllerData.Direction}");

        if ((Transform = gameObject.GetComponent<MBTransform>()) == null)
            Debug.Log($"Подключите к обьекту {gameObject.name} скрипт {ObjectControllerData.Transform}");

        if ((Animator = gameObject.GetComponent<MBAnimator>()) == null)
            Debug.Log($"Подключите к обьекту {gameObject.name} скрипт {ObjectControllerData.Animator}");

        if ((Rotation = gameObject.GetComponent<MBRotation>()) == null)
            Debug.Log($"Подключите к обьекту {gameObject.name} скрипт {ObjectControllerData.Rotation}");
    }

    public GameObject GameObj { private set; get; }

    public MBDirection Direction { private set; get; }
    public MBTransform Transform { private set; get; }
    public MBAnimator Animator { private set; get; }
    public MBRotation Rotation { private set; get; }
}
