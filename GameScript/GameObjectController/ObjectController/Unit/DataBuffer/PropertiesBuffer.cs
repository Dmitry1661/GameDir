/************************************************************************************************************/
/************************************************UnitDataBuffer**********************************************/
/************************************************************************************************************/
/*******************Хранит данные свойсв обьекта в КЕШАХ и осуществляет работу с ними.***********************/
/************************************************************************************************************/
using System.Collections.Generic;

public struct PropertyData
{
    public const string ATTACK_POWER = "ATTACK_POWER";
    public const string ATTACK_RELOAD = "ATTACK_RELOAD";
    public const string MOVE_SPEED = "MOVE_SPEED";
}

public class PropertiesBuffer : IIOBuffer<IBufferDataProcessing<PropertiesBuffer>, CacheProperty>
{
    public PropertiesBuffer(UnitSetting pUnitSetting)
    {
        CacheList.Add(new CacheProperty(PropertyData.ATTACK_POWER, pUnitSetting.AttackPower));
        CacheList.Add(new CacheProperty(PropertyData.ATTACK_RELOAD, pUnitSetting.AttackReload));
        CacheList.Add(new CacheProperty(PropertyData.MOVE_SPEED, pUnitSetting.MoveSpeed));
    }

    public void Input(IBufferDataProcessing<PropertiesBuffer> pUnitDataBuffer, string[] pInformation = null)
    {
        pUnitDataBuffer.Process(this, pInformation);
    }

    public CacheProperty Output(string pName)
    {
        return CacheList.Find(data => data.Name == pName);
    }

    private readonly List<CacheProperty> CacheList = new List<CacheProperty>();
}

