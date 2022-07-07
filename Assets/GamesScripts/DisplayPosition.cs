using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPosition : MonoBehaviour
{
    public Transform playerPosition;
    public GameObject player;
    public Text positionText;
    
    void Start()
    {
        player = GameObject.Find("Player");
        playerPosition = player.GetComponent<Transform>();
        positionText = GetComponent<Text>();
    }

    void Update()
    {
        positionText.text = playerPosition.position.z.ToString("0");
    }
}
