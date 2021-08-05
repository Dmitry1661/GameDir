public struct CacheUnitCharacteristic 
{
    public CacheUnitCharacteristic(UnitSetting pUnitSetting)
    {
        CurrentMoveSpeed = MoveSpeed = pUnitSetting.MoveSpeed;
        CurrentAttackSpeed = AttackSpeed = pUnitSetting.AttackSpeed;
        CurrentAttackPower = AttackPower = pUnitSetting.AttackPower;
    }

    public CacheUnitCharacteristic(CacheUnitCharacteristic pCache)
    {
        MoveSpeed = pCache.MoveSpeed;
        CurrentMoveSpeed = pCache.CurrentMoveSpeed;

        AttackSpeed = pCache.AttackSpeed;
        CurrentAttackSpeed = pCache.CurrentAttackSpeed;

        AttackPower = pCache.AttackPower;
        CurrentAttackPower = pCache.CurrentAttackPower;
    }

    /// <summary>
    /// Стандартая скорость передвижения.
    /// </summary>
    public float MoveSpeed { get; }

    /// <summary>
    /// Текущая скорость передвижения.(Она может измениться после наложения каких либо эфектов.)
    /// </summary>
    public float CurrentMoveSpeed { set; get; }

    /// <summary>
    /// Стандартная cкорость аттаки.
    /// </summary>
    public float AttackSpeed { get; }

    /// <summary>
    /// Текущая скорость атаки. (Она может измениться после наложение эфектов.)
    /// </summary>
    public float CurrentAttackSpeed { set; get; }

    /// <summary>
    /// Стандартная сила атаки.
    /// </summary>
    public float AttackPower { get; }
    /// <summary>
    /// Текущая сила атаки.
    /// </summary>
    public float CurrentAttackPower { set; get; }
}
