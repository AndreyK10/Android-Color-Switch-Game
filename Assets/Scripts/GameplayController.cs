using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameplayController : MonoBehaviour
{
    public Button jumpButton, pauseButton;
    public GameObject pausePanel, gameOverPanel;
    public TextMeshProUGUI highscoreText;

    public const string PREFS_HIGHSCORE = "Highscore_v1.0";

    private void Update()
    {
        if (PlayerController.isDead)
        {
            GameOver();
        }
    }

    public void PauseGame()
    {
        SwitchPause(0, false, false, true);
    }

    public void ContinueGame()
    {
        SwitchPause(1, true, true, false);
    }
    private void SwitchPause(float timescale, bool pausebutton, bool jumpbutton, bool pausepanel)
    {
        Time.timeScale = timescale;
        pauseButton.gameObject.SetActive(pausebutton);
        jumpButton.gameObject.SetActive(jumpbutton);
        pausePanel.gameObject.SetActive(pausepanel);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        jumpButton.gameObject.SetActive(false);
        if (ScoreScript.Score > PlayerPrefs.GetInt(PREFS_HIGHSCORE)) PlayerPrefs.SetInt(PREFS_HIGHSCORE, ScoreScript.Score);
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt(PREFS_HIGHSCORE).ToString();
    }
}
