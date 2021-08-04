public interface IMission
{
    /// <summary>
    /// Номер миссии.
    /// </summary>
    int Number { get; }

    /// <summary>
    /// Имя миссии.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Имя Prefab Cell.
    /// </summary>
    string CellName { get; }
}
