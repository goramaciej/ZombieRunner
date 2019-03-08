using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessageInstructions : MonoBehaviour
{
    /*
    Unity has 3 types of messaging
    - SendMessage() - can sends message to all components in current gameObject localy
    for example we've got game object with two scripts - send message
    handles communication between them in local scope

    - SendMessageUpwards() - can send messages to objects higher in the hierarchy
    (only to ancestors of object)

    - BroadcastMessage() - analogously to the above this method sends the message to all 
    child objects
    */
}
