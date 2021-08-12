using UnityEngine;

/// <summary>
/// Данный класс принимает текущую позицию, timeStep, и скорость с которой движется обьект.
/// </summary>
public class StepPositionX : INextPosition
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pStartPosition">Текущая позиция.</param>
    /// <param name="pTimeStep">TimeStep.</param>
    /// <param name="pSpeed">Скорость.</param>
    public StepPositionX(Vector3 pStartPosition, float pTimeStep, float pSpeed)
    {
        ResultPosition = new Vector3(pStartPosition.x + (pTimeStep * pSpeed),
                                     pStartPosition.y,
                                     pStartPosition.z);
    }

    public Vector3 ResultPosition { private set; get; }
}
