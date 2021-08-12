using UnityEngine;

/// <summary>
/// Переворачивает скорость.
/// </summary>
public class InvolutionMoveSpeed : IBufferDataProcessing<PropertiesBuffer>
{
    public void Process(PropertiesBuffer pUnitDataBuffer, string[] pInformation)
    {
        /*
        pUnitDataBuffer.MoveSpeed = new CacheProperty(pUnitDataBuffer.MoveSpeed.Standart,
                                                      pUnitDataBuffer.MoveSpeed.Intermediate,
                                                      pUnitDataBuffer.MoveSpeed.Current * -1);
        */
    }
}
