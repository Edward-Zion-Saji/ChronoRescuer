using UnityEngine;

public class dragonFly : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;

    void FixedUpdate()
    {
        rb.AddForce(0, 500*Time.deltaTime, forwardForce * Time.deltaTime);
    }
}