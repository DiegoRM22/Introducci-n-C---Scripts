using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositions : MonoBehaviour
{
    // Start is called before the first frame update
      // Set the new positions for the 3 figures
      public Vector3 sphereNewPosition = new Vector3(0, 0, 0);
      public Vector3 cubeNewPosition = new Vector3(0, 0, 0);
      public Vector3 cylinderNewPosition = new Vector3(0, 0, 0);
      GameObject sphere;
      GameObject cube;
      GameObject cylinder;
    void Start()
    {
      sphere = GameObject.FindWithTag("Red Sphere");
      cube = GameObject.FindWithTag("Blue Cube");
      cylinder = GameObject.FindWithTag("Green Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        // Set the new positions for the 3 figures
        sphere.transform.position = sphereNewPosition;
        cube.transform.position = cubeNewPosition;
        cylinder.transform.position = cylinderNewPosition;
      }
        
    }
}
