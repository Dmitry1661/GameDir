using UnityEngine;
using UnityEngine.SceneManagement;

/************************************************************************************************************/
/*******************************************...Game[)irecector...********************************************/
/************************************************************************************************************/

public class MBGameDir : MonoBehaviour
{
    public void Start()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("GameScene");
    }
}
