using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeheresManager : MonoBehaviour
{
  // Start is called before the first frame update
  GameObject MostCloseSphere(GameObject[] spheres) {
    GameObject mostClose = spheres[0];
    float minDistance = Vector3.Distance(spheres[0].transform.position, transform.position);
    for (int i = 1; i < spheres.Length; i++)
    {
      float distance = Vector3.Distance(spheres[i].transform.position, transform.position);
        if (distance < minDistance)
        { 
          minDistance = distance;
          mostClose = spheres[i];
        }
    }
    return mostClose;
  }
  GameObject MostFarSphere(GameObject[] spheres) {
    GameObject mostFar = spheres[0];
    float maxDistance = Vector3.Distance(spheres[0].transform.position, transform.position);
    for (int i = 1; i < spheres.Length; i++)
    {
      float distance = Vector3.Distance(spheres[i].transform.position, transform.position);
      if (distance > maxDistance)
      {
        maxDistance = distance;
        mostFar = spheres[i];
      }
    }
    return mostFar;
  }
  GameObject[] type2Spheres;
  public int heightIncrease = 2;

  void Start()
  {
    type2Spheres = GameObject.FindGameObjectsWithTag("Type2");
    GameObject mostClose = MostCloseSphere(type2Spheres);
    mostClose.GetComponent<Transform>().position = new Vector3(mostClose.transform.position.x, mostClose.transform.position.y +
                                                   heightIncrease, mostClose.transform.position.z);
  }
    // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      GameObject mostFar = MostFarSphere(type2Spheres);
      Material mostFarMaterial = mostFar.GetComponent<Renderer>().material;
      mostFarMaterial.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
  }
  
}