using UnityEngine;

public class MBCameraController : MonoBehaviour
{
    public void Start()
    {
        GameLogic = GameObject.Find(GameData.GAME_LOGIC).GetComponent<MBGameLogic>();
    }

    public void Update()
    {
        Vector3 vecLeft = new Vector3(GameLogic.UnitManager.Character.Position.Transform.position.x + OffsetCurrent.x,
                                      GameLogic.UnitManager.Character.Position.Transform.position.y - OffsetCurrent.y,
                                      -10);

        Vector3 vecRight = new Vector3(GameLogic.UnitManager.Character.Position.Transform.position.x - OffsetCurrent.x,
                                      GameLogic.UnitManager.Character.Position.Transform.position.y - OffsetCurrent.y,
                                      -10);

        Vector3 vecY = Vector3.Lerp(transform.position, vecRight, Dumping * Time.deltaTime * 100);

        if (GameLogic.UnitManager.Character.Direction.WatchDirection.HasFlag(WatchDirectionEnum.Right))
        {
            Vector3 vec = Vector3.Lerp(transform.position, vecLeft, Dumping * Time.deltaTime);
            transform.position = new Vector3(vec.x, vecY.y, -10);
        }
        else
        {
            Vector3 vec = Vector3.Lerp(transform.position, vecRight, Dumping * Time.deltaTime);
            transform.position = new Vector3(vec.x, vecY.y, -10);
        }
    }

    // Сглаживание камеры.
    public float Dumping;
    // Смещение камеры относильно персонажа.
    public Vector2 OffsetCurrent;
    public MBGameLogic GameLogic { private set; get; }
}
