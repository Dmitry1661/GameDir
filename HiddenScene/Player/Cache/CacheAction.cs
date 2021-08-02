public struct CacheAction
{
    public CacheAction(ActionType pActionType)
    {
        ActionType = pActionType;
    }

    public ActionType ActionType { set; get; }
}
