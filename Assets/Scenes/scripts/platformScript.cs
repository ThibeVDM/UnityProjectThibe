using UnityEngine;

public class platformScript : MonoBehaviour
{
    public float moveSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.up * moveSpeed) * Time.deltaTime;
        if (transform.position.y > 9.63 || transform.position.y < 1.7)
        {
            moveSpeed = 0 - moveSpeed;
        }
    }
}
