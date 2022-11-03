using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{
    float speed = 2.0f; // Variable used to multiply value of Time.deltaTime to increase rate that character moves.

    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed); // Move the character in the Z direction, using 'time elapsed between updates' as amount.
    }
}
