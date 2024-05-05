using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool gravity = true; //true == normal gravity, false == reverse gravity
    public float playerSpeed = 3f;
    public float fallSpeed = 20f;
    public Rigidbody2D rb;
    private bool gravitySwitched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        float initialFallSpeed = gravity ? -fallSpeed : fallSpeed;
        rb.velocity = new Vector2(playerSpeed, initialFallSpeed);
    }

    void Update()
    {   
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.G))
        {
            gravity = !gravity;
            if (gravitySwitched)
            {
                rb.velocity = Vector2.zero;
            }
            float currentFallSpeed = gravity ? -fallSpeed : fallSpeed;
            rb.velocity = new Vector2(rb.velocity.x, currentFallSpeed);
            gravitySwitched = true;
        }
    }
}