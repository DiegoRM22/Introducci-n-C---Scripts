using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distances : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      GameObject blueCube = GameObject.FindWithTag("Blue Cube");
      GameObject greenCylinder = GameObject.FindWithTag("Green Cylinder");
      Debug.Log("Distance from Cube: " + Vector3.Distance(blueCube.transform.position, transform.position));
      Debug.Log("Distance from Cylinder: " + Vector3.Distance(greenCylinder.transform.position, transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
