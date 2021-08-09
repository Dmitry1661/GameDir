public interface IDirection
{
    /// <summary>
    /// Напровление куда смотрит обьект.(В лево или в право. По умолчанию обьект всегда смотрит в право.)
    /// </summary>
    WatchDirectionEnum WatchDirection { get; }
}
