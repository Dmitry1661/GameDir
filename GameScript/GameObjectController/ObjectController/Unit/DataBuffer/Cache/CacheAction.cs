public struct CacheAction
{
    public CacheAction(ActionType pActionType)
    {
        Previous = Current = pActionType;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pCurrentActionType">Текущее событие.</param>
    /// <param name="pPreviousCacheAction">Предыдущий кеш.</param>
    public CacheAction(ActionType pCurrentActionType, CacheAction pPreviousCacheAction)
    {
        Current = pCurrentActionType;
        Previous = pPreviousCacheAction.Current;
    }

    /// <summary>
    /// Предыдущее событие.
    /// </summary>
    public ActionType Previous { private set; get; }
    /// <summary>
    /// Текущее событие.
    /// </summary>
    public ActionType Current { private set; get; }
}
