public struct ActionControllData
{
    /// <summary>
    /// Поднять флаг.
    /// </summary>
    public const string UPPER_THE_FLAG = "UPPER_THE_FLAG";

    /// <summary>
    /// Опустить флаг.
    /// </summary>
    public const string LOWER_THE_FLAG = "LOWER_THE_FLAG";

    /// <summary>
    /// Поднять один флаг.
    /// </summary>
    public const string UPPER_ONE_THE_FLAG = "UPPER_ONE_THE_FLAG";
}


public class ActionControll : IBufferDataProcessing<ActionType>
{
    /*
    public void Write(PropertyBuffer pUnitDataBuffer, string[] pInformation)
    {
        ActionType actionType = pUnitDataBuffer.Action.ActionType;

        switch(pInformation[0])
        {
            case ActionControllData.UPPER_THE_FLAG:

                actionType |= new HaveActionType(pInformation[1]).Result;

                break;

            case ActionControllData.LOWER_THE_FLAG:

                actionType ^= new HaveActionType(pInformation[1]).Result;

                break;

            case ActionControllData.UPPER_ONE_THE_FLAG:

                actionType = new HaveActionType(pInformation[1]).Result;

                break;
        }

        pUnitDataBuffer.Action = new UnitAction(actionType);
    }
    */
    public void Process(ActionType Buffer, string[] pInformation)
    {
        throw new System.NotImplementedException();
    }
}

public class HaveActionType
{
    public HaveActionType(string pActionType)
    {
        switch(pActionType)
        {
            case "RUN":

                Result = ActionType.Run;

                break;

            case "JUMP":

                Result = ActionType.Jump;

                break;

            case "ATTACK":

                Result = ActionType.Attack;

                break;
        }
    }

    public ActionType Result { private set; get; }
}

