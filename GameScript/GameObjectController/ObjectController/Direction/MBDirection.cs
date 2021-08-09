public class MBDirection : MBObjectsPointers, IDirection
{
    public void Update()
    {
        if (LeftObject.transform.position.x < RightObject.transform.position.x)
            WatchDirection = WatchDirectionEnum.Right;
        else
            WatchDirection = WatchDirectionEnum.Left;
    }

    public WatchDirectionEnum WatchDirection { private set; get; }
}
