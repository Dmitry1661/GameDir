public struct CacheUnitAction
{
    public CacheUnitAction(ActionType pActionType)
    {
        ActionType = pActionType;
    }

    /// <summary>
    /// Текущий тип дейсквия(Run, Idle, Attack ...)
    /// </summary>
    public ActionType ActionType { set; get; }
}
