using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool gravity = true; //true == normal gravity, false == reverse gravity
    public float playerSpeed = 3f;
    public Rigidbody2D rb;


    //is called before first frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //is called once per frame, used to check for input
    void Update()
    {   
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (gravity)
            {
                gravity = false;
                Physics2D.gravity = new Vector2(0, -20f);
            }
            else
            {
                gravity = true;
                Physics2D.gravity = new Vector2(0, 20f);
            }
        }
    }
}
