using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_ProjectilePickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D body;
 

    public ClothesManager cm;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

     void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.CompareTag("Clothes"))
         {
             Destroy(other.gameObject);
             cm.ClothesCount++;
         }
     }

}
