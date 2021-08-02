using UnityEngine;

public class MBDirection : MonoBehaviour
{
    public void Update()
    {
        if (LeftObject.transform.position.x < RightObject.transform.position.x)
            WatchDirection = WatchDirectionEnum.Rigth;
        else
            WatchDirection = WatchDirectionEnum.Left;
    }

    public WatchDirectionEnum WatchDirection { private set; get; }

    public GameObject LeftObject;
    public GameObject RightObject;
}
