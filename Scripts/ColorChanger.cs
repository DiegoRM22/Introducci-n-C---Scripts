using UnityEngine;

public class ColorChanger : MonoBehaviour
{
  // Vector de color inicializado con valores aleatorios
  private Color colorVector;
    
  // Tiempo en frames para cambiar el color
  [SerializeField]
  private int changeInterval = 120;

  private int frameCounter = 0;

  void Start()
  {
    // Inicializa el vector de color con valores aleatorios
    colorVector = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    // Asigna el color al objeto
    GetComponent<Renderer>().material.color = colorVector;
  }

  void Update()
  {
    frameCounter++;

    if (frameCounter >= changeInterval)
    {
      // Resetea el contador
      frameCounter = 0;

      // Cambia una posición aleatoria en el vector de color
      int randomIndex = Random.Range(0, 3); // 0: R, 1: G, 2: B

      // Genera un nuevo valor aleatorio para el componente correspondiente
      float newValue = Random.Range(0f, 1f);
      if (randomIndex == 0)
        colorVector.r = newValue;
      else if (randomIndex == 1)
        colorVector.g = newValue;
      else if (randomIndex == 2)
        colorVector.b = newValue;

      // Asigna el nuevo color al objeto
      GetComponent<Renderer>().material.color = colorVector;
    }
  }
}
