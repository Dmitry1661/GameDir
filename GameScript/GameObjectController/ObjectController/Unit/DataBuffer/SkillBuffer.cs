using System.Collections.Generic;

public struct SkillData
{
    public const string JUMP = "JUMP";
}

public class SkillBuffer : IIOBuffer<Dictionary<string, CacheSkill>, CacheSkill>
{
    public SkillBuffer(UnitSetting pSetting)
    {
    }

    public void Input(Dictionary<string, CacheSkill> pUnitDataBuffer, string[] pInformation = null)
    {
        throw new System.NotImplementedException();
    }

    public CacheSkill Output(string pName = null)
    {
        throw new System.NotImplementedException();
    }

    private Dictionary<string, CacheSkill> Dictionary = new Dictionary<string, CacheSkill>();
}
