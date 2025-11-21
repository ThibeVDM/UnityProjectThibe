using UnityEngine;

public class fireballscript2 : MonoBehaviour

{
    public float moveSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.up * moveSpeed) * Time.deltaTime;
        if (transform.position.y > 52.01)
        {
            Destroy(gameObject);
        }
    }
}
