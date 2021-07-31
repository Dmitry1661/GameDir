using UnityEngine;

public class MBAnimation : MonoBehaviour
{
    private Animator Animator;

    public void Start()
    {
        Animator = gameObject.GetComponent<Animator>();
    }

    public void Set(string pAnimName, bool pBool)
    {
        Animator.SetBool(pAnimName, pBool);
    }
}
