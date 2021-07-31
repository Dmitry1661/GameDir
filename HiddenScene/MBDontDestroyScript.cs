using UnityEngine;
using UnityEngine.SceneManagement;

public class MBDontDestroyScript : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);

        SceneManager.LoadScene("MenuScene");
    }
}
