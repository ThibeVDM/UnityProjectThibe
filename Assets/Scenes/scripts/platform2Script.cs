using UnityEngine;

public class platform2Script : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
     
    

    float minY = -2.39f;
    float maxY = 6f;
    float speed = 2f;

    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, maxY - minY) + minY;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
