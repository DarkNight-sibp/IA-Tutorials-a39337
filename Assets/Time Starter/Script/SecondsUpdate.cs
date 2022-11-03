using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float timeStartOffset = 0; // Variable to store seconds elapsed since starting.
    bool gotStartTime = false; // Variable to ensure offset is only changed once.

    void Update()
    {
        // Using real-word time to move the character.
        if (!gotStartTime)
        {
            timeStartOffset = Time.realtimeSinceStartup;
            gotStartTime = true;
        }

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 
                                    Time.realtimeSinceStartup - timeStartOffset);
    }
}
