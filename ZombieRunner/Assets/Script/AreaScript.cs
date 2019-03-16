using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaScript : MonoBehaviour
{
    //private float timeSinceLastTrigger = 0f;
    //private bool foundClearArea = false;
    private Collider mColl;

    public bool isCollide = true;

    void Update()
    {
        /*timeSinceLastTrigger += Time.deltaTime;
        if (timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea) {
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
        }*/


    }
    public bool CheckCollision()
    {
        mColl.enabled = true;
        return true;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Got Collision: " + collision.gameObject.tag);
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log("Got Trigger: " + other.tag);
        /*if(other.tag != "Player") {
            //timeSinceLastTrigger = 0f;
            return true;
        }else*/
    }
}
