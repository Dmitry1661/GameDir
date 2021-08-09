public struct CacheUnitCharacteristic 
{
    public CacheUnitCharacteristic(UnitSetting pUnitSetting)
    {
        CurrentMoveSpeed = MoveSpeed = pUnitSetting.MoveSpeed;

        AttackSpeed = pUnitSetting.AttackSpeed;
        CurrentAttackSpeed = 0.0f;

        CurrentAttackPower = AttackPower = pUnitSetting.AttackPower;

        CurrentCountJump = CountJump = pUnitSetting.CountJump;
        CurrentNumberJump = 0;

        CurrentPowerJump = PowerJump = pUnitSetting.PowerJump;
    }

    public CacheUnitCharacteristic(CacheUnitCharacteristic pCache)
    {
        MoveSpeed = pCache.MoveSpeed;
        CurrentMoveSpeed = pCache.CurrentMoveSpeed;

        AttackSpeed = pCache.AttackSpeed;
        CurrentAttackSpeed = pCache.CurrentAttackSpeed;

        AttackPower = pCache.AttackPower;
        CurrentAttackPower = pCache.CurrentAttackPower;

        CountJump = pCache.CountJump;
        CurrentCountJump = pCache.CurrentCountJump;

        CurrentNumberJump = pCache.CurrentNumberJump;

        PowerJump = pCache.PowerJump;
        CurrentPowerJump = pCache.CurrentPowerJump;
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
    /// Стандартная cкорость аттаки.(Количесво времени между отаками)
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

    /// <summary>
    /// Стандартное количесво прыжков.
    /// </summary>
    public float CountJump { set; get; }
    /// <summary>
    /// Текущее количесво прыжков.(Может измениться по ходу игры.)
    /// </summary>
    public float CurrentCountJump { set; get; }
    /// <summary>
    /// Номер текущего прыжка.(По умолчанию ноль)
    /// </summary>
    public float CurrentNumberJump { set; get; }

    /// <summary>
    /// Стандартная сила прыжка.
    /// </summary>
    public float PowerJump { get; }
    /// <summary>
    /// Текущая сила прыжка.
    /// </summary>
    public float CurrentPowerJump { set; get; }
}
