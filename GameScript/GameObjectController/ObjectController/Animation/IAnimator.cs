using UnityEngine;

public interface IAnimator
{
    /// <summary>
    /// Задает анимацию.
    /// </summary>
    /// <param name="pAnimData"></param>
    /// <param name="pBool"></param>
    void SetAnim(string pAnimData, bool pBool);

    Animator Animator { get; }
}
