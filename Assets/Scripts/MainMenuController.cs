using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;

    private void Start()
    {
        highscoreText.text = "Delete Highscore\n Current Highscore: " + PlayerPrefs.GetInt(GameplayController.PREFS_HIGHSCORE).ToString();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void DeleteHighscore()
    {
        PlayerPrefs.DeleteKey(GameplayController.PREFS_HIGHSCORE);
        highscoreText.text = "Delete Highscore\n Current Highscore: " + PlayerPrefs.GetInt(GameplayController.PREFS_HIGHSCORE).ToString();
    }
}
