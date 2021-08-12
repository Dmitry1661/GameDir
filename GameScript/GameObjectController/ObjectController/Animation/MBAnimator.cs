using UnityEngine;

public class MBAnimator : MonoBehaviour
{
    /// <summary>
    /// Задает анимацию.
    /// </summary>
    /// <param name="pAnimData"></param>
    /// <param name="pBool"></param>
    public void SetAnim(string pAnimData, bool pBool)
    {
        Animator.SetBool(pAnimData, pBool);
    }

    public void Start()
    {
        Animator = gameObject.GetComponent<Animator>();
    }

    public Animator Animator { private set; get; }
}
