using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 100f;
    public GameObject completeLevelUI;

    void FixedUpdate()
    {
        completeLevelUI.SetActive(false);
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            //for(int i = 0; i<100000000; i++);
            rb.AddForce(0, -80 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
		{
			FindObjectOfType<gameManager>().EndGame();
		}
    }
}
