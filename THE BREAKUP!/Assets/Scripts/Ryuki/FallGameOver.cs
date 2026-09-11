using UnityEngine;

public class FallGameOver : MonoBehaviour
{
    private GameOverMenu gameOverMenu;
    private AudioManager audioManager;

    public bool isCollected = false;

    private void Awake()
    {
        GameObject audioObj = GameObject.FindGameObjectWithTag("Audio");

        if (audioObj != null)
        {
            audioManager = audioObj.GetComponent<AudioManager>();
        }

        gameOverMenu = FindFirstObjectByType<GameOverMenu>();
    }

    void OnBecameInvisible()
    {
        if (isCollected)
        {
            return;
        }

        if (audioManager != null)
        {
            audioManager.PlaySFX(audioManager.death2);
        }

        if (gameOverMenu != null)
        {
            gameOverMenu.Pause();
        }
        Destroy(gameObject);
    }
}
