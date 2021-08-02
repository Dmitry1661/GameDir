public class PlayerManager : IPlayerManager
{
    public PlayerManager(CacheCharacteristic pCacheCharacteristic)
    {
        CacheCharacteristic = pCacheCharacteristic;

        SetAction(ActionType.Idle);
    }
    public PlayerManager()
    {
        SetAction(ActionType.Idle);
    }

    public void SetAction(ActionType pActionType)
    {
        CacheAction = new CacheAction(pActionType);
    }

    public CacheAction CacheAction { private set; get; }

    public CacheCharacteristic CacheCharacteristic { set; get; }
}
