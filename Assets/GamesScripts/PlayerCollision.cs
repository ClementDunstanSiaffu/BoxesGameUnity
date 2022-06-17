using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void Start()
    {
        movement = this.GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            FindObjectOfType<GameManagerScript>().endGame();
        }
    }
}
