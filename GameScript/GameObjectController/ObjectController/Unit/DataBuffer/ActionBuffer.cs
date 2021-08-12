using System;

[Flags]
public enum ActionType : short
{
    None = 0,
    Jump = 4,
    Attack = 8,
    Run = 16,
}

public class ActionBuffer : IIOBuffer<IBufferDataProcessing<ActionBuffer>, CacheAction>
{
    public ActionBuffer()
    {
        Action = new CacheAction(ActionType.None);
    }

    public void Input(IBufferDataProcessing<ActionBuffer> pUnitDataBuffer, string[] pInformation = null)
    {
        pUnitDataBuffer.Process(this, pInformation);
    }

    public CacheAction Output(string pName = null)
    {
        return Action;
    }

    private CacheAction Action;
}
