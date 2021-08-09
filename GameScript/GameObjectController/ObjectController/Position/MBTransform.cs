using UnityEngine;

public class MBTransform : MonoBehaviour
{
    public void NextPosition(Vector3 pNextPosition)
    {
        Transform.position = pNextPosition;
    }

    private void Start()
    {
        Rigidbody = gameObject.GetComponent<Rigidbody2D>();

        Transform = Rigidbody.transform;
    }

    public void Update()
    {
        Position = Transform.position;
    }

    public Vector3 Position { private set; get; }
    public Transform Transform { private set; get; }
    public Rigidbody2D Rigidbody { private set; get; }
}
