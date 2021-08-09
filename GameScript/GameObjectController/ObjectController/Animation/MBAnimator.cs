using UnityEngine;

public class MBAnimator : MonoBehaviour, IAnimator
{
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
