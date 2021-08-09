/************************************************************************************************************/
/************************************************UnitDataBuffer**********************************************/
/************************************************************************************************************/
/***********Храненит КЕШИ. КЕШИ открытые используются для быстрой записи или получения информации.***********/
/************************************************************************************************************/
public class UnitDataBuffer
{
    public UnitDataBuffer(CacheUnitCharacteristic pCacheUnitCharacteristic)
    {
        CacheAction = new CacheUnitAction(ActionType.None);
        CacheCharacteristic = new CacheUnitCharacteristic(pCacheUnitCharacteristic);
        CacheCountdown = new CacheUnitCountdown(pCacheUnitCharacteristic);
    }

    public void Write(IManagementCache pCache, string[] pInformation = null)
    {
        pCache.Write(ref CacheAction, ref CacheCountdown, ref CacheCharacteristic, pInformation);
    }

    public CacheUnitAction CacheAction;
    public CacheUnitCountdown CacheCountdown;
    public CacheUnitCharacteristic CacheCharacteristic;
}
