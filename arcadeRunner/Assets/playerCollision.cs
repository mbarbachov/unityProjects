using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We have hit an obstacle");
            movement.enabled = false;
        }
    }
}
