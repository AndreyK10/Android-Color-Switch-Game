using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if (transform.position.y < player.transform.position.y)
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}
