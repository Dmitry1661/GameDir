/************************************************************************************************************/
/*******************************************><InvolutionMoveSpeed><******************************************/
/************************************************************************************************************/
/*********************Класс реализующий процесс отвечающий за изменение данных в кеши.***********************/
/************************************************************************************************************/
using System.Collections.Generic;
public class InvolutionMoveSpeed : IBufferDataProcessing<List<CacheProperty>>
{
    /// <summary>
    /// Переворачивает MOVE_SPEED.
    /// </summary>
    /// <param name="pCacheList"></param>
    /// <param name="pInformation"></param>
    public void Process(ref List<CacheProperty> pCacheList, string[] pInformation)
    {
        CacheProperty cache = pCacheList.Find(index => index.Name == PropertyData.MOVE_SPEED);

        pCacheList.Remove(cache);

        pCacheList.Add(new CacheProperty(PropertyData.MOVE_SPEED, cache.Standart, cache.Intermediate, cache.Current * -1));
    }
}
