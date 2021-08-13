/************************************************************************************************************/
/*******************************************<_>ActionBuffer<_>***********************************************/
/************************************************************************************************************/
/*************Буфер который работает с КЕШЕМ отвечающим за "События" происходящие с Unit.********************/
/************************************************************************************************************/
using System;

[Flags]
public enum ActionType : short
{
    None = 0,
    Jump = 4,   // Прыжок.
    Attack = 8, // Стандартная атака.
    Run = 16,   // Движение по горизонтали.
}

public class ActionBuffer : IIOBuffer<IBufferDataProcessing<CacheAction>, CacheAction>
{
    public void Input(IBufferDataProcessing<CacheAction> pUnitDataBuffer, string[] pInformation = null)
    {
        pUnitDataBuffer.Process(ref Action, pInformation);
    }

    /// <summary>
    /// Возвращает кэш в котором хранится информация, о активности.
    /// </summary>
    /// <param name="pName">NULL</param>
    /// <returns></returns>
    public CacheAction Output(string pName = null)
    {
        return Action;
    }

    private CacheAction Action = new CacheAction(ActionType.None);
}
