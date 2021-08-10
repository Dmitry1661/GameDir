/************************************************************************************************************/
/************************************************UnitDataBuffer**********************************************/
/************************************************************************************************************/
/***********Храненит КЕШИ. КЕШИ открытые используются для быстрой записи или получения информации.***********/
/************************************************************************************************************/
using System.Collections.Generic;

public class DataBuffer
{
    public DataBuffer(UnitSetting pUnitSetting)
    {
        Action = new CacheUnitAction(ActionType.None);

        AttackPower = new CacheProperty<float>(pUnitSetting.AttackPower);
        AttackReload = new CacheProperty<float>(pUnitSetting.AttackReload);
        MoveSpeed = new CacheProperty<float>(pUnitSetting.MoveSpeed);
        CountJump = new CacheProperty<int>(pUnitSetting.CountJump);
        JumpPower = new CacheProperty<float>(pUnitSetting.AttackPower);
    }

    public void Write(IWriteCache pCache, string[] pInformation = null)
    { 
        pCache.Write(this, pInformation);
    }

    public CacheUnitAction Action;

    public CacheProperty<float> AttackPower;
    public CacheProperty<float> AttackReload;
    public CacheProperty<float> MoveSpeed;
    public CacheProperty<int> CountJump;
    public CacheProperty<float> JumpPower; 
}



