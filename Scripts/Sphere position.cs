using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphereposition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform sphereTransform = gameObject.GetComponent<Transform>();
        Debug.Log("Sphere position: " + sphereTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
