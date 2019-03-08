using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    [SerializeField] AudioClip callSound;

    private bool called = false;
    private AudioSource audioSource;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();

        FindAudioListeners();

    }

    public virtual void FindAudioListeners() {
        Debug.Log("Try to find listeners");
       
        AudioListener[] myListeners = FindObjectsOfType(typeof(AudioListener)) as AudioListener[];

        int totalListeners = 0;//find out how many listeners are actually active
        foreach (AudioListener thisListener in myListeners) {
            if (thisListener.enabled) { totalListeners++; }
        }

        Debug.Log("found:" + totalListeners + " audio listeners");
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("CallHelicopter")) {
            // key "h"
            CallHeli();
        }
	}

    public void CallHeli() {
        //HelicopterCalling.

        if (!called) {

            Debug.Log("Helicopter Called");
            called = true;
            audioSource.spatialBlend = 0;
            audioSource.clip = callSound;
            audioSource.Play();

            if (rb) {
                rb.velocity = new Vector3(0, 0, 50f);
            } else {
                Debug.LogError("Rigidbody on helicopter not found");
            }
        }
    }

    private void PlayHeliSound() {
        
    }
}
