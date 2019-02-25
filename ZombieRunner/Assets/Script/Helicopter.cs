using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool called = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("CallHelicopter")) {
            if (!called) {
                called = true; 
                PlayHeliSound();
            }           
        }
	}

    private void PlayHeliSound() {
        Debug.Log("Helicopter called");
    }
}
