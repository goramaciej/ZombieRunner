using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] Rigidbody projectilePrefab;
    [SerializeField] float shotPower = 1000;

    [SerializeField] GameObject smokePrefab;

    public void ExecuteShot()
    {
        Rigidbody myProj = Instantiate(projectilePrefab, transform.position, transform.rotation);
        myProj.AddForce(transform.forward * shotPower);

        GameObject smoke = Instantiate(smokePrefab, transform.position, transform.rotation);
        Destroy(smoke, 1f);
    }
}
