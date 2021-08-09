using UnityEngine;

public class MBRotation : MonoBehaviour, IRotation
{
    public void Rotation()
    {
        gameObject.transform.localScale = new Vector3(transform.localScale.x * -1.0f,
                                                      transform.localScale.y,
                                                      transform.localScale.z);
    }
}
