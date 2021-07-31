using UnityEngine;

/// <summary>
/// Равномерное горизонтальное движение обьекта.(Прощет производится в методе Update)
/// Вешается на обьект которому нужно двигаться строко по горизонтали.
/// Указываем напровление и скорость дальше обьект движется автоматически.
/// </summary>
public class MBUpdateHorizontalMovement : MonoBehaviour
{
    /*
    /// <summary>
    /// Запускает вертикальное движение обьекта.
    /// </summary>
    /// <param name="pDirection">Направление</param>
    public void Run(MoveDirection pDirection, float pSpeed)
    {
        Direction = pDirection;
        Speed = pSpeed;

        Transform = gameObject.GetComponent<Rigidbody2D>().transform;
    }

    public void Update()
    {
        if (Direction.HasFlag(MoveDirection.None)) return;

        Position = Transform.position;

        if (Direction.HasFlag(MoveDirection.Right))
        {
            Transform.position = new Vector3(Position.x + (Speed * Time.deltaTime),
                                             Position.y, 
                                             Position.z);
        }
        else if (Direction.HasFlag(MoveDirection.Left))
        {
            Transform.position = new Vector3(Position.x - (Speed * Time.deltaTime),
                                             Position.y, 
                                             Position.z);
        }
    }

    // Направление.
    public MoveDirection Direction { private set; get; }

    // Скорость.
    public float Speed { private set; get; }

    // Текущее место положение.
    public Transform Transform { private set; get; }
    public Vector3 Position { private set; get; }
    */
}
