using UnityEngine;

public class Level2PlatformScript : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    
    float minY = 21.07f;
    float maxY = 34.09f;
    float speed = 4f;

    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, maxY - minY) + minY;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
