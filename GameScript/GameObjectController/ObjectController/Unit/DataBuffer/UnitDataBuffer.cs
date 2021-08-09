/************************************************************************************************************/
/************************************************UnitDataBuffer**********************************************/
/************************************************************************************************************/
/***********Храненит КЕШИ. КЕШИ открытые используются для быстрой записи или получения информации.***********/
/************************************************************************************************************/
public class UnitDataBuffer
{
    public UnitDataBuffer(UnitSetting pUnitSetting)
    {
        CacheAction = new CacheUnitAction(ActionType.None);

        AttackPower = new CacheUnitAttackPower(pUnitSetting);
        AttackReload = new CacheUnitAttackReload(pUnitSetting);
        MoveSpeed = new CacheUnitMoveSpeed(pUnitSetting);

        CountJump = new CacheUnitCountJump(pUnitSetting);
    }

    public void Write(IWriteCache pCache, string[] pInformation = null)
    {
        pCache.Write(ref CacheAction, ref AttackPower,  ref AttackReload, pInformation);
    }

    public CacheUnitAction CacheAction;

    public CacheUnitAttackPower AttackPower;
    public CacheUnitAttackReload AttackReload;
    public CacheUnitMoveSpeed MoveSpeed;

    public CacheUnitCountJump CountJump;
}



