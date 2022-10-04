using UnityEngine;

public class player_script : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardMovement=2000f;
    public float sidewaysMovement=200f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardMovement*Time.deltaTime);
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,forwardMovement*Time.deltaTime);
        }
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysMovement*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysMovement*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y<-0.1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}
