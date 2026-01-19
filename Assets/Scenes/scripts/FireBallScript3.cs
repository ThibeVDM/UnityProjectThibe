using UnityEngine;

public class FireBallScript3 : MonoBehaviour
{
    public float moveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        if (transform.position.x > 169)
        {
            Destroy(gameObject);
        }
    }
}
