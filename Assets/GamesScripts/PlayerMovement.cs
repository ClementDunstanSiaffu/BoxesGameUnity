
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidbody;
    private float fowardForce = 6000f;
    private float sidewayForce = 100f;
    private Touch theTouch;
    private Vector2 touchStartPosition,touchEndPosition;
    private string direction;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);

            if (theTouch.phase == TouchPhase.Began)
            {
                touchStartPosition = theTouch.position;
            }else if (theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended)
            {
                touchEndPosition = theTouch.position;
            }

            float x = touchEndPosition.x - touchStartPosition.x;
            float y = touchEndPosition.y - touchStartPosition.y;

            if (Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
            {
                direction = "tapped";
            }else if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                direction = x > 0 ? "right" : "left";
            }
            else
            {
                direction = y > 0 ? "up" : "down";
            }
        }

        rigidbody.AddForce(0, 0, Time.deltaTime * fowardForce);
        if (Input.GetKey("right") || direction == "right")
        {
            rigidbody.AddForce(Time.deltaTime * sidewayForce, 0, 0,ForceMode.VelocityChange);
        }else if (Input.GetKey("left") || direction == "left")
        {
            rigidbody.AddForce(-1 * Time.deltaTime * sidewayForce, 0, 0,ForceMode.VelocityChange);
        }

        if (transform.position.y <= -1)
        {
            FindObjectOfType <GameManagerScript>().endGame();
        }
    }
}
