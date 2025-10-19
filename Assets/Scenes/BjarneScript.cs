using UnityEngine;

public class BjarneScript : MonoBehaviour
{
    public LogicScript logic;
    public bool bjarneIsAlive;
    public CameraFollowScript cameraFollowScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7 )
        {
            logic.gameOver();
            bjarneIsAlive = false;
            
        }
    }

    public void death()
    {
        logic.gameOver();
        Debug.Log("Dead");
        bjarneIsAlive = false;
    }

    

}
