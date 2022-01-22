using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRb2D;
    public int movmentSpeed = 10;




    // Start is called before the first frame update
    void Start()
    {
        playerRb2D = GetComponent<Rigidbody2D>();
    }


    //Put physica based movement in here
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb2D.velocity = new Vector2(movmentSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb2D.velocity = new Vector2(-movmentSpeed, 0);
        }
        else
        {
            playerRb2D.velocity = new Vector2(0, 0);
        }
    }
}
    