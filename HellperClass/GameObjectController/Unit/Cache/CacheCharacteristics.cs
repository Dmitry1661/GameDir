public struct CacheUnitCharacteristic
{
    public CacheUnitCharacteristic(float pAttackPower, float pAttackSpeed, float pMoveSpeed)
    {
        CurrentMoveSpeed = MoveSpeed = pMoveSpeed;
        CurrentAttackSpeed = AttackSpeed = pAttackSpeed;
        CurrentAttackPower = AttackPower = pAttackPower;
    }

    /// <summary>
    /// Стандартая скорость передвижения.
    /// </summary>
    public float MoveSpeed { get; }

    /// <summary>
    /// Текущая скорость передвижения.(Она может измениться после наложения каких либо эфектов.)
    /// </summary>
    public float CurrentMoveSpeed { get; }

    /// <summary>
    /// Стандартная cкорость аттаки.
    /// </summary>
    public float AttackSpeed { get; }

    /// <summary>
    /// Текущая скорость атаки. (Она может измениться после наложение эфектов.)
    /// </summary>
    public float CurrentAttackSpeed { get; }

    /// <summary>
    /// Стандартная сила атаки.
    /// </summary>
    public float AttackPower { get; }
    /// <summary>
    /// Текущая сила атаки.
    /// </summary>
    public float CurrentAttackPower { get; }
}
