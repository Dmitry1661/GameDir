using UnityEngine;

/// <summary>
/// Переворачивает скорость.
/// </summary>
public class MoveSpeedInvolution 
{
    public MoveSpeedInvolution(CacheUnitCharacteristic pCache)
    {
        pCache.CurrentMoveSpeed = pCache.CurrentMoveSpeed * -1;

        Result = new CacheUnitCharacteristic(pCache);
    }

    public CacheUnitCharacteristic Result { private set; get; }
}
