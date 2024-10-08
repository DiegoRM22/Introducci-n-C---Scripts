using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
  GameObject blueCube;
  GameObject greenCylinder;
    // Start is called before the first frame update
    void Start()
    {
      blueCube = GameObject.FindWithTag("Blue Cube");
      greenCylinder = GameObject.FindWithTag("Green Cylinder");        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.C)) {
        Material greenCylinderMaterial = greenCylinder.GetComponent<Renderer>().material;
        greenCylinderMaterial.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
      }
      if (Input.GetKeyDown(KeyCode.UpArrow)) {
        Material blueCubeMaterial = blueCube.GetComponent<Renderer>().material;
        blueCubeMaterial.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
      }
    }
}
