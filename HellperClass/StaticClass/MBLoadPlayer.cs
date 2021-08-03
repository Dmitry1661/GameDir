using UnityEngine;

public class MBLoadPlayer : MonoBehaviour
{
    public static CacheCharacteristic Get(string pKey)
    {
        return JsonUtility.FromJson<CacheCharacteristic>(MBPlayerPrefs.Load(pKey));
    }
}
