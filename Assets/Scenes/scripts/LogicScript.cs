using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject victoryScreen;
    public GameObject lavaWalker;
    public bool witchIsAlive = true;
    public bool portalIsalive = true;
    public bool doubleJumpTaken = false;
    public bool bjarneIsAlive = true;
    public bool flameIsAlive = true;
    public bool lowGravity = false;


    public void restartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
    public void victory()
    {
        victoryScreen.SetActive(true);

    }
    public void addScore(int scoreToAdd)
    {
        
    }
    public void powerUp3()
    {
        lavaWalker.SetActive(true);
    }
   
    
}
