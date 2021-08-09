/************************************************************************************************************/
/************************************************UnitDataBuffer**********************************************/
/************************************************************************************************************/
/***********Храненит КЕШИ. КЕШИ открытые используются для быстрой записи или получения информации.***********/
/************************************************************************************************************/
public class UnitDataBuffer
{
    public UnitDataBuffer(UnitSetting pUnitSetting)
    {
        Action = new CacheUnitAction(ActionType.None);

        AttackPower = new CacheUnitAttackPower(pUnitSetting);
        AttackReload = new CacheUnitAttackReload(pUnitSetting);
        MoveSpeed = new CacheUnitMoveSpeed(pUnitSetting);

        CountJump = new CacheUnitCountJump(pUnitSetting);
        PowerJump = new CacheUnitPowerJump(pUnitSetting);
    }

    public void Write(IWriteCache pCache, string[] pInformation = null)
    {
        pCache.Write(this, pInformation);
    }

    public CacheUnitAction Action;

    public CacheUnitAttackPower AttackPower;
    public CacheUnitAttackReload AttackReload;
    public CacheUnitMoveSpeed MoveSpeed;

    public CacheUnitCountJump CountJump;
    public CacheUnitPowerJump PowerJump;
}



