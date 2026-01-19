using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public Transform target;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (logic.lowGravity)
        {
            yOffset = -3;
        }
        if (!logic.lowGravity)
        {
            yOffset = 1;
        }
        
            Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        

    }
}
