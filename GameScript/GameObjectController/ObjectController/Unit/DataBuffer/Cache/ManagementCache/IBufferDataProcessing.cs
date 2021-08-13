/// <summary>
/// 
/// </summary>
/// <typeparam name="T">Принимает тип кеша или список кешей.</typeparam>
public interface IBufferDataProcessing<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pCaches">КЕШ</param>
    /// <param name="pInformationArray">Принимает дополнительную информацию.</param>
    void Process(ref T pCaches, string[] pInformationArray);
}
