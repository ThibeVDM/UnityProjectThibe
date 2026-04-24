using UnityEngine;

public class BigGoombaScript : MonoBehaviour
{
    public GameObject player;
    
    private float distance;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    float minX = 47f;
    float maxX = 60.5f;
    float speed = 3f;

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, maxX - minX) + minX;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fireball"))
        {
            speed = 0 - speed;
        }
    }
}
