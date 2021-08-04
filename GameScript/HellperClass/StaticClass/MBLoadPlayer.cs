using UnityEngine;

public class MBLoadPlayer : MonoBehaviour
{
    public static CacheUnitCharacteristic Get(string pKey)
    {
        return JsonUtility.FromJson<CacheUnitCharacteristic>(MBPlayerPrefs.Load(pKey));
    }
}
