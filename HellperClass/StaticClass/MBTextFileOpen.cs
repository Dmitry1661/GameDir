using UnityEngine;

/// <summary>
/// Oткрывает Текстовый файл.
/// </summary>
public class MBTextFileOpen : MonoBehaviour
{
    /// <summary>
    /// Получаем строку из файла JSON.
    /// </summary>
    /// <param name="pPath">Пусть до файла.</param>
    /// <returns></returns>
    public static string Read(string pPath)
    {
        TextAsset bindata = Resources.Load(pPath) as TextAsset;


        //Player player1 = new Player();
        //string json = JsonUtility.ToJson(new II());
        //print(json);

        // Из джейсона.
        //Player player = JsonUtility.FromJson<Player>(str);

        //Save save = new Save();

        //string jsonSave = JsonUtility.ToJson(save);

        return bindata.text;
    }
}

class II
{
}


