using UnityEngine;
using UnityEngine.UIElements;

public class BjarneScript : MonoBehaviour
{
    public LogicScript logic;
    private bool bjarneIsAlive;
    public CameraFollowScript cameraFollowScript;
   
    



    public bool BjarneIsAlive { get => bjarneIsAlive; set => bjarneIsAlive = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    

    public void death()
    {
        logic.gameOver();
        Debug.Log("Dead");
        bjarneIsAlive = false;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spike")){
            death();
        }
        if (other.gameObject.CompareTag("Fireball"))
        {
            death();
        }
        if (other.gameObject.CompareTag("Witch"))
        {
            Destroy(other.gameObject);
            logic.witchIsAlive = false;
        }
        if (other.gameObject.CompareTag("Goomba"))
        {
            death();
        }


    }

}
