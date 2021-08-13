/************************************************************************************************************/
/*******************************************><InvolutionMoveSpeed><******************************************/
/************************************************************************************************************/
/*********************Класс реализующий процесс отвечающий за изменение данных в кеши.***********************/
/************************************************************************************************************/
using System.Collections.Generic;
public class InvolutionMoveSpeed : IBufferDataProcessing<Dictionary<string, CacheProperty>>
{
    /// <summary>
    /// Переворачивает MOVE_SPEED.
    /// </summary>
    /// <param name="pCaches"></param>
    /// <param name="pInformationArray"></param>
    public void Process(ref Dictionary<string, CacheProperty> pCaches, string[] pInformationArray)
    {
        CacheProperty cache = pCaches[PropertyData.MOVE_SPEED];
        pCaches[PropertyData.MOVE_SPEED] = new CacheProperty(cache.Standart, cache.Intermediate, cache.Current * -1);
    }
}
