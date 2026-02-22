using UnityEngine;

public class Level2PlatformScript : MonoBehaviour
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
        if (transform.position.y > 34.09 || transform.position.y < 21.07)
        {
            moveSpeed = 0 - moveSpeed;
        }
    }
}
