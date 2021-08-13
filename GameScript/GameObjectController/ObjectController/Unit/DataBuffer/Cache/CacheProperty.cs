/************************************************************************************************************/
/*******************************************[.]CacheProperty[.]**********************************************/
/************************************************************************************************************/
/******************Структура предназначеная для хранения численных данных(Свойсв Unit).**********************/
/******************[1]. Standart - Стандартное значение. Данное свойсво не должно изменяться!****************/
/****************[2]. Intermediate - Промежуточное значение. Используется для подчета Current.***************/
/****[3]. Current - Текущее значение. Это итоговый результат игровой логики, который мы применяем к Unit.****/
/************************************************************************************************************/
public struct CacheProperty
{ 
    public CacheProperty(float pPropertySize)
    {
        Standart = Intermediate = Current = pPropertySize;
    }
    public CacheProperty(CacheProperty pCacheProperty)
    {
        Standart = pCacheProperty.Standart;
        Intermediate = pCacheProperty.Intermediate;
        Current = pCacheProperty.Current;
    }
    public CacheProperty(float pStandart, float pIntermediate, float pCurrent)
    {
        Standart = pStandart;
        Intermediate = pIntermediate;
        Current = pCurrent;
    }

    /// <summary>
    /// Стандартное значение свойсва(не изменяется)
    /// </summary>
    public float Standart { private set; get; }
    /// <summary>
    /// Промежуточное значение свойва.
    /// </summary>
    public float Intermediate { private set; get; }
    /// <summary>
    /// Текущее значение свойсва.
    /// </summary>
    public float Current { private set; get; }
}
