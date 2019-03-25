using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{


    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("bullet collision: " + collision.gameObject.tag);
        
        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.GetComponent<ZombieScript>())
            {
                ZombieScript zombie = collision.gameObject.GetComponent<ZombieScript>();
                zombie.Die();
            }
        }
        Destroy(gameObject);
    }
}