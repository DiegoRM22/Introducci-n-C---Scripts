using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Get the tag of the object
    public string tag;
    // Start is called before the first frame update
    void Start()
    {
        tag = gameObject.tag;
        // Print the position of the object
        Debug.Log(tag + " position: " + gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
