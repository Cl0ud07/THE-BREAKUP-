using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void Pause()
    {
        if (pauseMenu != null)
        {
            audioManager.PlaySFX(audioManager.home);
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
   
    public void Resume()
    {
        audioManager.PlaySFX(audioManager.retry);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
        
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
