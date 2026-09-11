using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip death;
    public AudioClip death2;
    public AudioClip gf;
    public AudioClip clothes;
    public AudioClip weapon;
    public AudioClip walk;
    public AudioClip collected;
    public AudioClip home;
    public AudioClip retry;
    public AudioClip resume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicSource.clip = background;
        musicSource.volume = 0.5f;
        musicSource.Play();
    }

    // Update is called once per frame
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
