using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaScript : MonoBehaviour
{
    private float timeSinceLastTrigger = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime;
        if (timeSinceLastTrigger > 1f) {
            SendMessageUpwards

        }
    }

    private void OnTriggerStay(Collider other) {
        timeSinceLastTrigger = 0f;
    }
}
