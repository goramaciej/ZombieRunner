using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {
    [SerializeField] AudioClip initialHeliCall;
    [SerializeField] AudioClip initialCallReply;

    private AudioSource mAs;
    // Start is called before the first frame update
    void Start()
    {
        mAs = GetComponent<AudioSource>();
    }

    public void PlaySound(string audioClipName) {
        //Debug.Log("RadioSystem playSound: " + audioClipName);
    }

    public void OnMakeInitialHeliCall() {
        /*Debug.Log(name + " OnMakeInitialHeliCall");
        mAs.clip = initialHeliCall;
        mAs.Play();
        Invoke("InitialReply", initialHeliCall.length + 1f);
        */
    }

    void InitialReply() {
        /*mAs.clip = initialCallReply;
        mAs.Play();
        BroadcastMessage("OnDispatchHelicopter");
        */
    }
}
