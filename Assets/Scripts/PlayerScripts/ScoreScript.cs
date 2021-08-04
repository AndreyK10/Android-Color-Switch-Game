using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private int score;
    public static int Score;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<ColorSwitch>())
        {
            score += 1;
            Score = score;
        }            
    }
}
