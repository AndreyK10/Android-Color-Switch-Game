using UnityEngine;

public class CleanerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.GetComponent<PlayerController>())
            Destroy(collision.gameObject);        
    }
}
