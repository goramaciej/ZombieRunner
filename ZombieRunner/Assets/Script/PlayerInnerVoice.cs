using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInnerVoice : MonoBehaviour {

    [SerializeField] AudioClip whatHappened;
    [SerializeField] AudioClip goodLandingArea;

    private AudioSource audioS;

    // Start is called before the first frame update
    void Start() {
        /*audioS = GetComponent<AudioSource>();
        audioS.clip = whatHappened;
        audioS.Play();*/
    }

    // Update is called once per frame
    void OnFindClearArea() {
        /*Debug.Log(name + " OnFindClearArea");
        audioS.clip = goodLandingArea;
        audioS.Play();

        // invoke callHelicopter private function after time (goodLandingArea audio clip
        // duration + 1 second
        Invoke("CallHelicopter", goodLandingArea.length + 1);*/
    }

    private void CallHelicopter() {
        //SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
