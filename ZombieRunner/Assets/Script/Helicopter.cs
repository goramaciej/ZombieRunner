using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool called = false;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

        //FindAudioListeners();
    }

    public void CallHelicopter()
    {
        Debug.Log("Helicopter called");
    }

    public void OnDispatchHelicopter() {
        //HelicopterCalling.

        if (!called) { 
            called = true;

            try {
                rb.velocity = new Vector3(0, 0, 50f);
            } catch {
                Debug.LogError("Rigidbody on helicopter not found");
            }
        }
    }
}
