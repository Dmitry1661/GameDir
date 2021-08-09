using UnityEngine;

/// <summary>
/// Переворачивает скорость.
/// </summary>
public class MoveSpeedInvolution : IWriteCache
{
    public void Write(ref CacheUnitAction pUnitAction, ref CacheUnitCountdown pUnitCoolDown, 
        ref CacheUnitCharacteristic pCacheUnitCharacteristic, string [] pInformaion)
    {
        pCacheUnitCharacteristic.CurrentMoveSpeed = pCacheUnitCharacteristic.CurrentMoveSpeed * -1;
    }
}
