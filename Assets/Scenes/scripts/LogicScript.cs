using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public MovementScript movementScript;
    public GameObject victoryScreen;
    public GameObject lavaWalker;
    public GameObject goombaInstruction;
    public GameObject superjumpText;
    public GameObject deadEyes;
    public GameObject trampolinePic;
    public GameObject trampolineBounce;
    public GameObject pijlen;
    public GameObject textPowerUpWandelen;
    public GameObject blokkade;
    public bool witchIsAlive = true;
    public bool portalIsalive = true;
    public bool doubleJumpTaken = false;
    public bool bjarneIsAlive = true;
    public bool flameIsAlive = true;
    public bool lowGravity = false;
    public bool PrinsesUitzicht = false;
    public bool speerOmhoog = false;
    public bool BossDefeated = false;
    public bool Level2 = false;
    public bool LevelBoss = false;


    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("CLICK");
    }

    public void restartFullGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        Debug.Log("CLICK");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void PlayBoss()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
    public void victory()
    {
        victoryScreen.SetActive(true);
        


    }
    public void gameVictory()
    {
        victoryScreen.SetActive(true);

    }
    public void trampolineVisible()
    {
        trampolineBounce.SetActive(true);
        trampolinePic.SetActive(true);
    }
    public void deadEyesOn() {
        deadEyes.SetActive(true);
    }
    public void prinsesGezien()
    {
        blokkade.SetActive(true);
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
        textPowerUpWandelen.SetActive(true);
        pijlen.SetActive(true);
    }
   
    
}
