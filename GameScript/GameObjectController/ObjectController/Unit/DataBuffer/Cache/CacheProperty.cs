using System;

public struct CacheProperty<T> 
{
    public CacheProperty(T pPropertySize)
    {
        Standart = Intermediate = Current = pPropertySize;
    }

    public CacheProperty(T pStandart, T pIntermediate, T pCurrent)
    {
        Standart = pStandart;
        Intermediate = pIntermediate;
        Current = pCurrent;
    }

    public T Standart { private set; get; }
    public T Intermediate { private set; get; }
    public T Current { private set; get; }
}
