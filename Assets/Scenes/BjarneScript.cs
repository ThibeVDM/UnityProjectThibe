using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class BjarneScript : MonoBehaviour
{
    public LogicScript logic;
    public CameraFollowScript cameraFollowScript;
    private float goombaCount = 0;
    public GameObject respawnPoint;
    public GameObject respawnPoint1;
    public GameObject respawnPoint2;
    private float respawnPointNumber = 0;
    public float lifes = 3;
    private float score = 0;
    public Text scoreText;
    public Text lifesText;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
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
        lifes = lifes - 1;
        lifesText.text = lifes.ToString();

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
        if (other.gameObject.CompareTag("apple"))
        {
            death();
        }
        if (other.gameObject.CompareTag("doubleJump"))
        {
            Destroy(other.gameObject);
            logic.doubleJumpTaken = true;
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
        }
        if (other.gameObject.CompareTag("apple"))
        {
            Destroy(other.gameObject);
            
        }
    }

}
