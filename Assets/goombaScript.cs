using UnityEngine;

public class goombaScript : MonoBehaviour
{
    public GameObject player;
    public float speed = 2;
    private float distance;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fireball"))
        {
            speed = 0 - speed;
        }
    }
}
