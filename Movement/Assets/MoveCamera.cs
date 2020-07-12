using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform player;

    public void Update()
    {
        transform.position = player.transform.position;
    }

}
