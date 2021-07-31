using UnityEngine;

public class MBRespown : MonoBehaviour
{
    public void Respown(Vector3 pPosition)
    {
        gameObject.transform.position = pPosition;
    }
}
