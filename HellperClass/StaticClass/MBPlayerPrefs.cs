using UnityEngine;

public class MBPlayerPrefs : MonoBehaviour
{
    public static void Save(string pPrefsName, string pPrefsValue)
    {
        if (PlayerPrefs.HasKey(pPrefsName))
            Debug.LogError($"Prefs с именем " + pPrefsName + " уже сущесвует.");
        else
            PlayerPrefs.SetString(pPrefsName, pPrefsValue);
    }

    public static void Rewrite(string pPrefsName, string pPrefsValue)
    {
        if (PlayerPrefs.HasKey(pPrefsName))
            PlayerPrefs.SetString(pPrefsName, pPrefsValue);
        else
            Debug.LogError($"Перезапись невозможна.Prefs с именем " + pPrefsName + " не сущесвует.");
    }

    private static object locker = new object();

    public static string Load(string pPrefsName)
    {
        string prefs = "";

        if (PlayerPrefs.HasKey(pPrefsName))
            prefs = PlayerPrefs.GetString(pPrefsName);

        return prefs;
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }
}
