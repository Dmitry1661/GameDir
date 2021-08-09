using System;

[Flags]
public enum ActionType : short
{
    None = 0,
    Jump = 4,
    Attack = 8,
    Run = 16,
}
