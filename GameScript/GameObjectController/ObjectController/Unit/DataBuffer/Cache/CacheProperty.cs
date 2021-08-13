/************************************************************************************************************/
/*******************************************[.]CacheProperty[.]**********************************************/
/************************************************************************************************************/
/******************Структура предназначеная для хранения численных данных(Свойсв Unit).**********************/
/*************************************[1]. Name - Наименование свойсва.**************************************/
/******************[2]. Standart - Стандартное значение. Данное свойсво не должно изменяться!****************/
/****************[3]. Intermediate - Промежуточное значение. Используется для подчета Current.***************/
/****[4]. Current - Текущее значение. Это итоговый результат игровой логики, который мы применяем к Unit.****/
/************************************************************************************************************/
public struct CacheProperty 
{
    public CacheProperty(string pName, float pPropertySize)
    {
        Name = pName;
        Standart = Intermediate = Current = pPropertySize;
    }
    public CacheProperty(CacheProperty pCacheProperty)
    {
        Name = pCacheProperty.Name;
        Standart = pCacheProperty.Standart;
        Intermediate = pCacheProperty.Intermediate;
        Current = pCacheProperty.Current;
    }
    public CacheProperty(string pName, float pStandart, float pIntermediate, float pCurrent)
    {
        Name = pName;
        Standart = pStandart;
        Intermediate = pIntermediate;
        Current = pCurrent;
    }

    /// <summary>
    /// Наиманование свойсва.
    /// </summary>
    public string Name { private set; get; }
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
