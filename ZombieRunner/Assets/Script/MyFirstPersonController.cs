using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson {
    public class MyFirstPersonController : FirstPersonController {


        /*override public void SetAudioSource() {
            Debug.Log("overriden SetAudioSource in MyFirstPersonController called");
            AudioSource[] audioSources = GetComponents<AudioSource>();
            foreach(AudioSource audioSource in audioSources) {
                if (audioSource.priority == 128) {
                    //m_AudioSource = audioSource;
                }
            }
        }*/
    }
}
