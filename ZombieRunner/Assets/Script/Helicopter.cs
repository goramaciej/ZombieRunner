using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    [SerializeField] AudioClip callSound;

    private bool called = false;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        Debug.Log("helicopter script started;");
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
        //HelicopterCalling.
        Debug.Log("Helicopter called");
        audioSource.spatialBlend = 0;
        audioSource.clip = callSound;
    }
}
