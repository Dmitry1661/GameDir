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

public class ActionControll : IBufferDataProcessing<CacheAction>
{
    public void Process(ref CacheAction pCacheAction, string[] pInformationArray)
    {
        ActionType actionType = pCacheAction.Current;

        switch(pInformationArray[0])
        {
            case ActionControllData.UPPER_THE_FLAG:

                actionType |= new HaveActionType(pInformationArray[1]).Result;

                break;

            case ActionControllData.LOWER_THE_FLAG:

                actionType ^= new HaveActionType(pInformationArray[1]).Result;

                break;

            case ActionControllData.UPPER_ONE_THE_FLAG:

                actionType = new HaveActionType(pInformationArray[1]).Result;

                break;
        }

        pCacheAction = new CacheAction(actionType, pCacheAction);
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

