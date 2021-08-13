/************************************************************************************************************/
/*********************************************~PropertiesBuffer~*********************************************/
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

public class PropertiesBuffer : IIOBuffer<IBufferDataProcessing<List<CacheProperty>>, CacheProperty>
{
    public PropertiesBuffer(UnitSetting pUnitSetting)
    {
        CacheList.Add(new CacheProperty(PropertyData.ATTACK_POWER, pUnitSetting.AttackPower));
        CacheList.Add(new CacheProperty(PropertyData.ATTACK_RELOAD, pUnitSetting.AttackReload));
        CacheList.Add(new CacheProperty(PropertyData.MOVE_SPEED, pUnitSetting.MoveSpeed));
    }

    public void Input(IBufferDataProcessing<List<CacheProperty>> pUnitDataBuffer, string[] pInformation = null)
    {
        pUnitDataBuffer.Process(ref CacheList, pInformation);
    }

    public CacheProperty Output(string pName)
    {
        return CacheList.Find(data => data.Name == pName);
    }

    private List<CacheProperty> CacheList = new List<CacheProperty>();
}

