using UnityEngine;

/// <summary>
/// Переворачивает скорость.
/// </summary>
public class MoveSpeedInvolution : IWriteCache
{
    public void Write(UnitDataBuffer pUnitDataBuffer, string[] pInformation)
    {
        pUnitDataBuffer.MoveSpeed = new CacheUnitMoveSpeed(pUnitDataBuffer.MoveSpeed.Standart,
                                                            pUnitDataBuffer.MoveSpeed.Intermediate,
                                                            pUnitDataBuffer.MoveSpeed.Current * -1);
    }
}
