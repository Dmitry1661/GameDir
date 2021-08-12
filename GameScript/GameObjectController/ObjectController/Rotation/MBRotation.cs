using UnityEngine;

/// <summary>
/// Вешаеться на обьект. Производит разворот. Обьект всегда по стандарту смотрит на право.
/// </summary>
public class MBRotation : MonoBehaviour
{
    /// <summary>
    /// Разворачивает обьект.
    /// </summary>
    public void Rotation()
    {
        gameObject.transform.localScale = new Vector3(transform.localScale.x * -1.0f,
                                                      transform.localScale.y,
                                                      transform.localScale.z);
    }
}
