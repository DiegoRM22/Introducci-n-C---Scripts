using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
  // Start is called before the first frame update+
  public Vector3 vector1 = new Vector3(1, 2, 3);
  public Vector3 vector2 = new Vector3(4, 5, 6);

  Vector3 MaxHeight(Vector3 vector1, Vector3 vector2)
  {
    if (vector1.y > vector2.y)
      return vector1;
    else
      return vector2;
  }

  void Start()
  {
    // Mostrar la magnitud de los vectores
    Debug.Log("Vector 1: " + vector1);
    Debug.Log("Vector 2: " + vector2);
    // Ángulo que forman los vectores
    Debug.Log("Ángulo entre los vectores: " + Vector3.Angle(vector1, vector2));
    // Distancia entre los vectores
    Debug.Log("Distancia entre los vectores: " + Vector3.Distance(vector1, vector2));
    // Vector que está a mayor altura
    Debug.Log("Vector más alto: " + MaxHeight(vector1, vector2));
  }

  // Update is called once per frame
  void Update()
  {
      
  }
}
