public interface ICacheUnitSetting<T>
{
    T Standart { get; }
    T Intermediate { get; }
    T Current { get; }
}
