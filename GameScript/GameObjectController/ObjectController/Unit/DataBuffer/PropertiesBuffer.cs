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

public class PropertiesBuffer : IIOBuffer<IBufferDataProcessing<Dictionary<string, CacheProperty>>, CacheProperty>
{
    public PropertiesBuffer(UnitSetting pUnitSetting)
    {
        Dictionary.Add(PropertyData.ATTACK_POWER, new CacheProperty(pUnitSetting.AttackPower));
        Dictionary.Add(PropertyData.ATTACK_RELOAD, new CacheProperty(pUnitSetting.AttackReload));
        Dictionary.Add(PropertyData.MOVE_SPEED, new CacheProperty(pUnitSetting.MoveSpeed));
    }

    public void Input(IBufferDataProcessing<Dictionary<string, CacheProperty>> pUnitDataBuffer, string[] pInformation = null)
    {
        pUnitDataBuffer.Process(ref Dictionary, pInformation);
    }

    public CacheProperty Output(string pName)
    {
        return Dictionary[pName];
    }

    private Dictionary<string, CacheProperty> Dictionary = new Dictionary<string, CacheProperty>();
}

