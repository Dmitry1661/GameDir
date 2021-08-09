public interface IManagementCache
{
    void Write(ref CacheUnitAction pUnitAction, ref CacheUnitCountdown pUnitCoolDown, 
        ref CacheUnitCharacteristic pCacheUnitCharacteristic, string[] pInformation);
}
