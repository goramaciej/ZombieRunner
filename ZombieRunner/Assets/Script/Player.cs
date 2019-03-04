using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //List<SpawnPoint> spawnPoints;
    private SpawnPoint[] mySpawnPoints;
    private SpawnPoint currentSpawnPoint;

    [SerializeField] bool respawnNow;

    private void Start() {
        mySpawnPoints = FindObjectsOfType<SpawnPoint>();
        /// We can also use the parent of all spawn points, and getting transforms from children:
        /// private Transform[] spawnPoints;
        /// spawn points = playerSpawnPoints.GetComponentsInChildren<Transform>();
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
        Debug.Log("Found clear area in player");
    }


}
