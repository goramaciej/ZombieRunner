using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLightManager : MonoBehaviour {

    [Tooltip("Number of minutes per second")][SerializeField] float minutesPerSecond = 200;
	
	// Update is called once per frame
	void Update () {
        float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
