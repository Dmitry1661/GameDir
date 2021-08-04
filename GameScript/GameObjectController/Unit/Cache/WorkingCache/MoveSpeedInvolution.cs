using UnityEngine;

/// <summary>
/// Переворачивает скорость.
/// </summary>
public class MoveSpeedInvolution 
{
    public MoveSpeedInvolution(CacheUnitCharacteristic pCache)
    {
        Result = new CacheUnitCharacteristic(pCache.AttackPower, pCache.AttackSpeed, pCache.MoveSpeed * -1);
    }

    public CacheUnitCharacteristic Result { private set; get; }
}
