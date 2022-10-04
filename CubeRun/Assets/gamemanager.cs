
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{

    public GameObject completelevelUI;
    bool gamehasended = false;
    public float restartdelay=1f;
   
    public void EndGame()
    {

        if(gamehasended==false)
        {
            gamehasended = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartdelay);
        }   
    }

    void Restart()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void GameComplete()
    {
        Debug.Log("Level Completed");
        completelevelUI.SetActive(true);
        Invoke("QuitGame",1);
    }
}
