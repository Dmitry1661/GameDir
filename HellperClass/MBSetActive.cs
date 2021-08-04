using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// На вешивается на Button
/// </summary>
public class MBSetActive : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        foreach(GameObject obj in ShowObjectArray)
        {
            obj.SetActive(true);
        }

        foreach(GameObject obj in HiddenObjectArray)
        {
            obj.SetActive(false);
        }
    }

    public GameObject[] ShowObjectArray;
    public GameObject[] HiddenObjectArray;
}
