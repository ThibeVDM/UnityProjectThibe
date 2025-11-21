using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public bool witchIsAlive = true;
    public bool portalIsalive = true;
    
    public bool bjarneIsAlive = true;


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
    public void addScore(int scoreToAdd)
    {
        
    }
   
    
}
