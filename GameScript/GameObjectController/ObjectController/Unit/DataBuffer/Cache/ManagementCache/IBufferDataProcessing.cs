public interface IBufferDataProcessing<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pBuffer">Принимает буффер из которого вызывается метод.</param>
    /// <param name="pInformation">Принимает дополнительную информацию.</param>
    void Process(T pBuffer, string[] pInformation);
}
