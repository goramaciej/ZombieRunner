using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    // Description - player can run arround whole map, when he find place where helicopter can land he presses "h" on keyboard to call it.

    [SerializeField] bool respawnNow;
    [SerializeField] GameObject LandingAreaPrefab;
    [SerializeField] AudioClip shootSound;
    //[SerializeField] Helicopter helicopter;

    //List<SpawnPoint> spawnPoints;
    private SpawnPoint[] mySpawnPoints;
    private SpawnPoint currentSpawnPoint;
    private bool helicopterCalled = false;

    private void Start() {
        mySpawnPoints = FindObjectsOfType<SpawnPoint>();
        /// We can also use the parent of all spawn points, and getting transforms from children:
        /// private Transform[] spawnPoints;
        /// spawn points = playerSpawnPoints.GetComponentsInChildren<Transform>();

        //PlayWhatHappenedAudioClip();
    }

    private void ReSpawn() {
        int mRan = Random.Range(0, mySpawnPoints.Length);
        //Debug.Log(mRan);
        currentSpawnPoint = mySpawnPoints[mRan];
        transform.position = currentSpawnPoint.transform.position;
    }

    private void Update() {
        if (respawnNow) {
            ReSpawn();
            respawnNow = false;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }

        if (Input.GetButtonDown("CallHelicopter"))
        {
            // key "h"
            //OnDispatchHelicopter();
            CallHelicopter();            
        }
    }

    private void Shot()
    {
        ShootSound();
        Animator myAnim = GetComponentInChildren<Animator>();
        myAnim.SetTrigger("Recoil");
        BroadcastMessage("ExecuteShot");
        Debug.Log("shot! "+myAnim);
    }


    private void CallHelicopter()
    {
        if (!helicopterCalled)
        {
            helicopterCalled = true;
            DropFlare();
            //OnDispatchHelicopter();
            Helicopter heli = FindObjectOfType<Helicopter>();
            heli.OnDispatchHelicopter();
        }
    }


    private bool CheckArea()
    {
        return true;
        //isCollide
        //AreaScript myArea = FindObjectOfType<AreaScript>();
        //return myArea.CheckCollision();
    }

    void OnFindClearArea() {
        /*if (helicopter) {
            //helicopter.CallHeli();
        } else {
            Debug.LogError("Helicopter not specified in Player");
        }*/
    }

    private void DropFlare()
    {
        Debug.Log("DropFlare");
        Instantiate(LandingAreaPrefab, transform.position, transform.rotation);
    }

    private void ShootSound()
    {
        AudioSource m_audioSource = GetComponent<AudioSource>();
        m_audioSource.clip = shootSound;
        m_audioSource.Play();
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
