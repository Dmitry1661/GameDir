using UnityEngine;

public class MBCameraController : MonoBehaviour
{
    /*
    private void Start()
    {
        CharacterPosition = GameObject.FindGameObjectWithTag("Character").GetComponent<MBRigidBody>();
        CharacterDirection = GameObject.FindGameObjectWithTag("Character").GetComponent<MBCharacterDirection>();

        if (CharacterDirection.DirectionRight)
        {
            transform.position = new Vector3(CharacterPosition.Position.x + OffsetCurrent.x,
                                             CharacterPosition.Position.y - OffsetCurrent.y,
                                             -10);
        }
    }

    void Update()
    {
        SetPositionCameraMove();
    }

    public void SetPositionCameraMove()
    {
        Vector3 vecLeft = new Vector3(CharacterPosition.Position.x + OffsetCurrent.x,
                                      CharacterPosition.Position.y - OffsetCurrent.y,
                                      -10);

        Vector3 vecRight = new Vector3(CharacterPosition.Position.x - OffsetCurrent.x,
                                      CharacterPosition.Position.y - OffsetCurrent.y,
                                      -10);

        Vector3 vecY = Vector3.Lerp(transform.position, vecRight, Dumping * Time.deltaTime * 100);

        if (!CharacterDirection.DirectionRight)
        {
            Vector3 vec = Vector3.Lerp(transform.position, vecRight, Dumping * Time.deltaTime);
            transform.position = new Vector3(vec.x, vecY.y, -10);
        }
        else
        {
            Vector3 vec = Vector3.Lerp(transform.position, vecLeft, Dumping * Time.deltaTime);
            transform.position = new Vector3(vec.x, vecY.y, -10);
        }
    }

    private MBRigidBody CharacterPosition;
    private MBCharacterDirection CharacterDirection;

    // Сглаживание камеры.
    private float Dumping = 5f;
    // Смещение камеры относильно персонажа.
    private Vector2 OffsetCurrent = new Vector2(4f, -0.3f);
    */
}
