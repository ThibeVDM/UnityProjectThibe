using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject victoryScreen;
    public GameObject lavaWalker;
    public GameObject goombaInstruction;
    public GameObject superjumpText;
    public bool witchIsAlive = true;
    public bool portalIsalive = true;
    public bool doubleJumpTaken = false;
    public bool bjarneIsAlive = true;
    public bool flameIsAlive = true;
    public bool lowGravity = false;


    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("CLICK");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
    public void victory()
    {
        victoryScreen.SetActive(true);

    }
    public void witchDead()
    {
        goombaInstruction.SetActive(true);

    }
    public void goombaDead()
    {
        goombaInstruction.SetActive(false);

    }
    public void superjumpActive()
    {
        superjumpText.SetActive(true);

    }
    public void superjumDeactive()
    {
        superjumpText.SetActive(false);

    }

    public void addScore(int scoreToAdd)
    {
        
    }
    public void powerUp3()
    {
        lavaWalker.SetActive(true);
    }
   
    
}
