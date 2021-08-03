using UnityEngine;

public class MBGameObjectController : MonoBehaviour, IGameObjectController
{
    public void Awake()
    {
        GameObj = gameObject;

        Direction = gameObject.GetComponent<MBDirection>();
        Position = gameObject.GetComponent<MBTransform>();
        Animator = gameObject.GetComponent<MBAnimator>();
        Rotation = gameObject.GetComponent<MBRotation>();
    }

    public GameObject GameObj { private set; get; }

    public MBDirection Direction { private set; get; }
    public MBTransform Position { private set; get; }
    public MBAnimator Animator { private set; get; }
    public MBRotation Rotation { private set; get; }
}
