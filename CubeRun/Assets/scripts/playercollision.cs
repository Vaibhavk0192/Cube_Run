
using UnityEngine;

public class playercollision : MonoBehaviour
{

    public player_script playerMovement;

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "obstacle")
        {
            Debug.Log("hit by obstacle");
            playerMovement.enabled=false;
            FindObjectOfType<gamemanager>().EndGame();
        }

        if (other.collider.tag=="endline")
        {
            FindObjectOfType<gamemanager>().GameComplete();  
        }
    }
}
