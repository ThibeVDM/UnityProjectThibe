using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.TextCore.Text;

public class BjarneScript : MonoBehaviour
{
    public LogicScript logic;
    public CameraFollowScript cameraFollowScript;
    public MovementScript movementScript;
    private float goombaCount = 0;
    private float appleCount = 0;
    public GameObject respawnPoint;
    public GameObject respawnPoint1;
    public GameObject respawnPoint2;
    public GameObject respawnPoint3;
    private float respawnPointNumber = 0;
    public float lifes = 3;
    private float score = 0;
    public Text scoreText;
    public Text lifesText;
    public Rigidbody2D rb;
   







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goombaCount == 5)
        {
            logic.portalIsalive = false;
        }
        if (lifes == 0)
        {
            gameOver();
        }
        if (appleCount == 3)
        {
            logic.flameIsAlive = false;
            movementScript.jumpingPower = 5;
        }

    }

    
    

    public void death()
    {
        if(respawnPointNumber == 0) { 
            transform.position = respawnPoint.transform.position; 
        }
        else if (respawnPointNumber == 1)
        {
            transform.position = respawnPoint1.transform.position;
        }
        else if (respawnPointNumber == 2)
        {
            transform.position = respawnPoint2.transform.position;
        }
        else if (respawnPointNumber == 3)
        {
            transform.position = respawnPoint3.transform.position;
        }
        lifes = lifes - 1;
        lifesText.text = lifes.ToString();
        movementScript.jumpingPower = 5;
    }

    public void gameOver()
    {
        
            logic.gameOver();
            Debug.Log("Dead");
        logic.bjarneIsAlive = false;
        
        
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
        if (other.gameObject.CompareTag("Fireball1"))
        {
            death();
        }
        if (other.gameObject.CompareTag("Witch"))
        {
            addScore();
            Destroy(other.gameObject);
            logic.witchIsAlive = false;
                    
        }
        if (other.gameObject.CompareTag("Goomba"))
        {
            death();
        }
        if (other.gameObject.CompareTag("Checkpoint1"))
        {
            respawnPointNumber = respawnPointNumber + 1;
            Destroy(other.gameObject);
            addScore();
        }
        if (other.gameObject.CompareTag("Checkpoint2"))
        {
            respawnPointNumber = respawnPointNumber + 1;
            Destroy(other.gameObject);
            addScore();

        }
        if (other.gameObject.CompareTag("Checkpoint3"))
        {
            respawnPointNumber = respawnPointNumber + 1;
            Destroy(other.gameObject);
            addScore();
            rb.gravityScale = 0.3f;
            logic.lowGravity = true;
            
            
        }
        if (other.gameObject.CompareTag("apple"))
        {
            death();
        }
        if (other.gameObject.CompareTag("doubleJump"))
        {
            Destroy(other.gameObject);
            movementScript.jumpingPower = 10;
        }
        if (other.gameObject.CompareTag("End"))
        {
            logic.victory();

        }


        if (other.gameObject.CompareTag("EndGround"))
        {
           logic.lowGravity = false; 
        }
        if (other.gameObject.CompareTag("LavaWalker"))
        {
            logic.powerUp3();
            Destroy(other.gameObject);
        }




    }

    public void addScore()
    {
        score = score + 1;
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Goomba"))
        {
            Destroy(other.gameObject);
            goombaCount = goombaCount + 1;
            addScore();
        }
        if (other.gameObject.CompareTag("apple"))
        {
            Destroy(other.gameObject);
            appleCount = appleCount + 1;
            addScore();

        }
    }

}
