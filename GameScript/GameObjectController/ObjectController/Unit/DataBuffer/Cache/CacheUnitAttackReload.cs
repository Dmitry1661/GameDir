public struct CacheUnitAttackReload : ICacheUnitSetting<float>
{
    public CacheUnitAttackReload(UnitSetting pUnitSetting)
    {
        Standart = Intermediate = Current = pUnitSetting.AttackReload;
    }

    public float Standart { private set; get; }
    public float Intermediate { private set; get; }
    public float Current { private set; get; }
}

