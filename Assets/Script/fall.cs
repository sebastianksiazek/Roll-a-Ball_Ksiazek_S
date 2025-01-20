using UnityEngine;

public class fall : MonoBehaviour
{
    public Vector3 startPosition; // Punkt startowy gracza

    private void Start()
    {
        // Zapisanie początkowej pozycji gracza
        startPosition = transform.position;
    }

private void OnTriggerEnter(Collider other)
{
    // Sprawdzamy, z czym gracz wchodzi w kolizję
    Debug.Log("Wykryto kolizję z: " + other.gameObject.name);

    // Sprawdzamy, czy kolizja jest z odpowiednią platformą
    if (other.gameObject.CompareTag("SafeZone"))
    {
        Debug.Log("Dotknięto SafeZone! Resetowanie pozycji.");
        ResetPlayerPosition();
    }
}


    private void ResetPlayerPosition()
    {
        // Resetowanie pozycji gracza
        CharacterController controller = GetComponent<CharacterController>();

        if (controller != null)
        {
            controller.enabled = false; // Wyłączanie CharacterController przed zmianą pozycji
            transform.position = startPosition;
            controller.enabled = true;  // Włączanie CharacterController po zmianie pozycji
        }
        else
        {
            transform.position = startPosition; // Jeśli nie ma CharacterController
        }
    }
}
