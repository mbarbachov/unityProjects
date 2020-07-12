using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We mark it as "Fixed"Update because we are using it to mess with physics
    void FixedUpdate(){
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // get the key that was pressed down. If a key was pressed we move correspondingly
        if (Input.GetKey("d") || Input.GetKey("right")) {
            // Move right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a") || Input.GetKey("left")) {
            // Move left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
