using UnityEngine;

/// <summary>
/// Вешаеться на обьект. Производит разворот. Обьект всегда по стандарту смотрит на право.
/// </summary>
public class MBRotation : MonoBehaviour
{
    //Если обьект уже повернут в право, то игнарируем.
    public void Rotation(bool pIsRight = false)
    {
        if (!pIsRight)
        {
            Rotation();
        }
    }

    private void Rotation()
    {
        gameObject.transform.localScale = new Vector3(transform.localScale.x * -1.0f,
                                                      transform.localScale.y,
                                                      transform.localScale.z);
    }
}
