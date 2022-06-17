using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndScript : MonoBehaviour
{
  void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Player")
        {
            FindObjectOfType<GameManagerScript>().hasGameStopped = true;
            FindObjectOfType<GameManagerScript>().showLevelPanel();
        }
    }
}
