using System;

[Flags]
public enum ActionType : short
{
    None = 0,
    Jump = 4,
    Attack = 8,
    Run = 16,
}

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
