/// <summary>
/// 
/// </summary>
/// <typeparam name="T">Принимает тип кеша или список кешей.</typeparam>
public interface IBufferDataProcessing<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pCache">КЕШ</param>
    /// <param name="pInformation">Принимает дополнительную информацию.</param>
    void Process(ref T pCache, string[] pInformation);
}
