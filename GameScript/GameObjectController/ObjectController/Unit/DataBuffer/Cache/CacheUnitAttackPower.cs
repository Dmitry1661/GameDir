public struct CacheUnitAttackPower : ICacheUnitSetting<float>
{
    public CacheUnitAttackPower(UnitSetting pUnitSetting)
    {
        Standart = Intermediate = Current = pUnitSetting.AttackPower;
    }

    public float Standart { private set; get; }
    public float Intermediate { private set; get; }
    public float Current { private set; get; }
}
