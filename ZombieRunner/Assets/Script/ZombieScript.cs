using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    private bool isAttacking;
    private Animator myAnimator;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void Die()
    {
        Debug.Log("Zombie dying");
    }


    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Zombie has Collision: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            isAttacking = true;
            Debug.Log("Zombie collides the player;");
        }
        else
        {
            isAttacking = false;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("collisionExit!!!");
    }


    private void Update()
    {
        if (isAttacking)
        {
            myAnimator.SetBool("IsAttacking", true);
        }
    }
}
