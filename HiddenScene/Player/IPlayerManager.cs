public interface IPlayerManager
{
    void Load();

    void Save();
    void Reload();

    CacheCharacteristic CacheCharacteristic { set; get; }
}
