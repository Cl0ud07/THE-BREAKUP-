using UnityEngine;

public class SpawnWeaponSound : MonoBehaviour
{
    AudioManager audioManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        audioManager.PlaySFX(audioManager.gf);
        audioManager.PlaySFX(audioManager.weapon);
    }
}
