using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Transform playerPosition;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerPosition = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPosition.position + offset;
    }
}
