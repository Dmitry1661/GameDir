/// <summary>
/// Класс помошник. Обрезает строку в начале и в конце.
/// </summary>
public class StringRemove
{
    public StringRemove(string pString, int pLength)
    {
        StringResult = StrRemove(pString, pLength);
    }

    public string StrRemove(string str, int i)
    {
        string buffer = "";
        buffer = str.Remove(0, i);//.Remove(str.Length - i);
        return buffer.Remove(buffer.Length - i);
    }

    public string StringResult;
}
