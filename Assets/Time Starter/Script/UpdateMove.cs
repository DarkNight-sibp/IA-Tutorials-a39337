using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{
    public float speed = 0.5f; //Vai mais depressa, not slower?? note 2 - this one is goig faster even though they all have the same number in the speed code???.the code looks the same as in the titorial so idk
    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
