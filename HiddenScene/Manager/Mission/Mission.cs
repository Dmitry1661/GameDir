public class Mission : IMission
{
    public Mission(int pNumber, string pName, string pCellName)
    {
        Number = pNumber;
        Name = pName;
        CellName = pCellName;
    }

    public int Number { private set; get; }

    public string Name { private set; get; }

    public string CellName { private set; get; }
}
