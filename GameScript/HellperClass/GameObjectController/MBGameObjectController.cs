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

        try
        {
            Direction = gameObject.GetComponent<MBDirection>();
        }
        catch(MissingComponentException ex)
        {
            MBLogMCE.Log(gameObject.name, ObjectControllerData.Direction, ex);
        }

        try
        {
            Position = gameObject.GetComponent<MBTransform>();
        }
        catch(MissingComponentException ex)
        {
            MBLogMCE.Log(gameObject.name, ObjectControllerData.Position, ex);
        }

        try
        {
            Animator = gameObject.GetComponent<MBAnimator>();
        }
        catch(MissingComponentException ex)
        {
            MBLogMCE.Log(gameObject.name, ObjectControllerData.Animator, ex);
        }

        try
        {
            Rotation = gameObject.GetComponent<MBRotation>();
        }
        catch(MissingComponentException ex)
        {
            MBLogMCE.Log(gameObject.name, ObjectControllerData.Rotation, ex);
        }

    }

    public GameObject GameObj { private set; get; }

    public MBDirection Direction { private set; get; }
    public MBTransform Position { private set; get; }
    public MBAnimator Animator { private set; get; }
    public MBRotation Rotation { private set; get; }
}
