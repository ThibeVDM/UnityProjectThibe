using UnityEngine;

public class platformScript : MonoBehaviour
{
    public float moveSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    float minY = 1.7f;
    float maxY = 9.63f;
    float speed = 2f;

    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, maxY - minY) + minY;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
