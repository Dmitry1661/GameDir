using UnityEngine;

/// <summary>
/// Класс для загрузки Mission.
/// </summary>
public class MBLoadMission : MonoBehaviour
{
    /// <summary>
    /// Создать обьект Mission из строки(JSON). 
    /// </summary>
    /// <param name="pNumber">Номер миссии.</param>
    /// <returns></returns>
    public static Mission Get(string pPath)
    {
        return JsonUtility.FromJson<Mission>(MBTextFileOpen.Read(pPath));
    }
}
