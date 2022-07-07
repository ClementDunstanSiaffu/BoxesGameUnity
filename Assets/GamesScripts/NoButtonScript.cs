
using UnityEngine;

public class NoButtonScript : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("quiting");
        Application.Quit();
    }
}
