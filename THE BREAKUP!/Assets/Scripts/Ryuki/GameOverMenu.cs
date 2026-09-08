using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] GameObject pauseButton;

    void Start()
    {
        gameOverMenu.SetActive(false);
    }
    public void Pause()
    {
        if (gameOverMenu != null)
        {
            gameOverMenu.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void Home()
    {
        if (gameOverMenu != null)
        {
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
