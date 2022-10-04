
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{ 
   public void StartGame()
    {
        Debug.Log("game is started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
