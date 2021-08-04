using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerController : MonoBehaviour
{
    private SpriteRenderer sr;

    public static bool isDead;

    private void Awake()
    {        
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        isDead = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<SpriteRenderer>())
        {
            if (collision.GetComponent<SpriteRenderer>().color != sr.color)
            {
                GameOver();
            }
        }
        if (collision.GetComponent<CleanerScript>())
        {
            GameOver();           
        }
    }
    private void GameOver()
    {
        AudioManager.instance.PlaySound(AudioManager.GAME_OVER_SOUND);
        isDead = true;
        gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}
