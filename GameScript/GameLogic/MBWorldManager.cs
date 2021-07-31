using UnityEngine;

public class MBWorldManager : MonoBehaviour
{
    public void Add(GameObject pCell)
    {
        Cell = pCell;
    }

    public GameObject Cell { private set; get; }
}
