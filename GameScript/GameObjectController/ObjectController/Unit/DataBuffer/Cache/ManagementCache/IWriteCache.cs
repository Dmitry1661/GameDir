public interface IWriteCache
{
    void Write(ref CacheUnitAction pUnitAction, ref CacheUnitAttackPower pAttackPower, 
        ref CacheUnitAttackReload pAttackCountdown, string[] pInformation);
}
