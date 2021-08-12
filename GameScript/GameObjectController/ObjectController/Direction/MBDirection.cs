public class MBDirection : MBObjectsPointers
{
    public void Update()
    {
        if (LeftObject.transform.position.x < RightObject.transform.position.x)
            WatchDirection = WatchDirectionEnum.Right;
        else
            WatchDirection = WatchDirectionEnum.Left;
    }

    /// <summary>
    /// Напровление куда смотрит обьект.(В лево или в право. По умолчанию обьект всегда смотрит в право.)
    /// </summary>
    public WatchDirectionEnum WatchDirection { private set; get; }
}
