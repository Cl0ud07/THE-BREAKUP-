using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_ProjectilePickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D body;
    AudioManager audioManager;

    public GameOverMenu gameOverMenu;

    public ClothesManager cm;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

     void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.CompareTag("Clothes"))
         {
            Destroy(other.gameObject);
            audioManager.PlaySFX(audioManager.collected);
            cm.ClothesCount++;
         }
        else if (other.gameObject.CompareTag("Weapon"))
        {
            Destroy(other.gameObject);
            audioManager.PlaySFX(audioManager.death);
            gameOverMenu.Pause();
        }
     }

}
