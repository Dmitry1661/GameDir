public struct CacheUnitPowerJump : ICacheUnitSetting<float>
{
    public CacheUnitPowerJump(UnitSetting pUnitSetting)
    {
        Standart = Intermediate = Current = pUnitSetting.MoveSpeed;
    }

    public float Standart { private set; get; }
    public float Intermediate { private set; get; }
    public float Current { private set; get; }
}
