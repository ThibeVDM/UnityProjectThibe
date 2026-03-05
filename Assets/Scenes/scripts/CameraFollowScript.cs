using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset;
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
        if (logic.PrinsesUitzicht)
        {
            yOffset = 3;
        }
        if (logic.BossDefeated)
        {
            yOffset = 3;
        }



        Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        

    }
}
