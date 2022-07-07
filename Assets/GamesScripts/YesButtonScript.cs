
using UnityEngine;
using UnityEngine.SceneManagement;

public class YesButtonScript : MonoBehaviour
{
   public void Continue()
    {
        SceneManager.LoadScene(0);
    }
}
