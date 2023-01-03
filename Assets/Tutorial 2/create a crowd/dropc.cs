using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropc : MonoBehaviour
{
    public GameObject obstacle; 
    GameObject[] agents; 
    
    // Start is called before the first frame update
    void Start() 
    { 
        agents = GameObject.FindGameObjectsWithTag("ag ent");
    } 
    // Update is called once per frame
    void Update() 
    { 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitinfo; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitinfo)) 
            { 
               // Instantiate(obstacle, hitinfo.point, obstacle.transform.rotation);
              //  foreach (GameObject a in agents)
                {
                 //   a.GetComponent<AIControl>().DetectNewObstacle(hitinfo.point);
                }
            }
        }
    }
}
