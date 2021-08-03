public struct CacheCharacteristic
{
    public CacheCharacteristic(float pAttackPower, float pAttackSpeed, float pMoveSpeed)
    {
        CurrentMoveSpeed = MoveSpeed = pMoveSpeed;
        CurrentAttackSpeed = AttackSpeed = pAttackSpeed;
        CurrentAttackPower = AttackPower = pAttackPower;
    }

    /// <summary>
    /// Стандартая скорость передвижения.
    /// </summary>
    public float MoveSpeed { private set; get; }

    /// <summary>
    /// Текущая скорость передвижения.(Она может измениться после наложения каких либо эфектов.)
    /// </summary>
    public float CurrentMoveSpeed { set; get; }

    /// <summary>
    /// Стандартная cкорость аттаки.
    /// </summary>
    public float AttackSpeed { private set; get; }

    /// <summary>
    /// Текущая скорость атаки. (Она может измениться после наложение эфектов.)
    /// </summary>
    public float CurrentAttackSpeed { set; get; }

    /// <summary>
    /// Стандартная сила атаки.
    /// </summary>
    public float AttackPower { private set; get; }
    /// <summary>
    /// Текущая сила атаки.
    /// </summary>
    public float CurrentAttackPower { private set; get; }
}
