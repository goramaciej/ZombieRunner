﻿using System.Collections;
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

    
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("CallHelicopter")) {
            // key "h"
            OnDispatchHelicopter();
        }
	}

    private  void OnDispatchHelicopter() {
        //HelicopterCalling.

        if (!called) { 
            called = true;

            //SendMessageUpwards("PlaySound", "CallHelicopter");
            //SendMessage("PlaySound");

            try {
                rb.velocity = new Vector3(0, 0, 50f);
            } catch {
                Debug.LogError("Rigidbody on helicopter not found");
            }
        }
    }
}
