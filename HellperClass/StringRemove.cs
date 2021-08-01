/// <summary>
/// Класс помошник. Обрезает строку в начале и в конце.
/// </summary>
public class StringRemove
{
    public StringRemove(string pString, int pLength)
    {
        StringResult = StrRemove(pString, pLength);
    }

    /// <summary>
    /// Обрезает строку с двух сторон.
    /// </summary>
    /// <param name="str"></param>
    /// <param name="i"></param>
    /// <returns></returns>
    public string StrRemove(string str, int i)
    {
        string buffer = "";
        buffer = str.Remove(0, i);//.Remove(str.Length - i);
        return buffer.Remove(buffer.Length - i);
    }

    public string StringResult;
}
