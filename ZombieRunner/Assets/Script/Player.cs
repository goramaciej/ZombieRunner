using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] bool respawnNow;
    //[SerializeField] Helicopter helicopter;

    //List<SpawnPoint> spawnPoints;
    private SpawnPoint[] mySpawnPoints;
    private SpawnPoint currentSpawnPoint;

    private void Start() {
        mySpawnPoints = FindObjectsOfType<SpawnPoint>();
        /// We can also use the parent of all spawn points, and getting transforms from children:
        /// private Transform[] spawnPoints;
        /// spawn points = playerSpawnPoints.GetComponentsInChildren<Transform>();

        //PlayWhatHappenedAudioClip();
    }

    private void ReSpawn() {
        int mRan = Random.Range(0, mySpawnPoints.Length);
        Debug.Log(mRan);
        currentSpawnPoint = mySpawnPoints[mRan];
        transform.position = currentSpawnPoint.transform.position;
    }

    private void Update() {
        if (respawnNow) {
            ReSpawn();
            respawnNow = false;
        }
    }

    void OnFindClearArea() {
        /*if (helicopter) {
            //helicopter.CallHeli();
        } else {
            Debug.LogError("Helicopter not specified in Player");
        }*/
    }


    /*private void PlayWhatHappenedAudioClip() {
        // get AudioSource with priority 1;
        AudioSource[] audioSources = GetComponents<AudioSource>();
        foreach(AudioSource audioS in audioSources) {
            if (audioS.priority == 1) {
                innerVoice = audioS;
            }
        }
        if (innerVoice) {
            Debug.Log("try to play");
            innerVoice.clip = whatHappenedAudioClip;
            innerVoice.Play();
        }
    }*/


}
