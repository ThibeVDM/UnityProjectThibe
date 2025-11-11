using Unity.VisualScripting;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    private float horizontal;
    public float speed = 6f;
    public float jumpingPower = 5f;
    private bool isFacingRight = true;
    bool grounded;
    
    

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    

    // Update is called once per frame
    void Update()
    {
        
        
            horizontal = Input.GetAxisRaw("Horizontal");
            if (Input.GetKeyDown(KeyCode.Space) && grounded)
            {
                rb.linearVelocity = Vector2.up * jumpingPower;
            }


            Flip();
        
        
        
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocityY);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
        if (other.gameObject.CompareTag("Spike"))
        {
            speed = 0;
            jumpingPower = 0;
        }
        if (other.gameObject.CompareTag("Fireball"))
        {
            speed = 0;
            jumpingPower = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (groundCheck == null) return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, 0.2f);
    }

    private void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    
}
