public struct CacheUnitCountJump : ICacheUnitSetting<int>
{
    public CacheUnitCountJump(UnitSetting pUnitSetting)
    {
        Standart = Intermediate = Current = pUnitSetting.CountJump;
    }

    public int Standart { private set; get; }
    public int Intermediate { private set; get; }
    public int Current { private set; get; }
}
