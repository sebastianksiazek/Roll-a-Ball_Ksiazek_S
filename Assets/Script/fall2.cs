using UnityEngine;

public class fall2 : MonoBehaviour
{
    public Vector3 startPosition; // Punkt startowy gracza

    private void Start()
    {
        // Zapisanie pocz�tkowej pozycji gracza
        //startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdzamy, z czym gracz wchodzi w kolizj�
        Debug.Log("Wykryto kolizj� z: " + other.gameObject.name);

        // Sprawdzamy, czy kolizja jest z odpowiedni� platform�
        if (other.gameObject.CompareTag("SafeZone2"))
        {
            Debug.Log("Dotkni�to SafeZone2! Resetowanie pozycji.");
            ResetPlayerPosition();
        }
    }


    private void ResetPlayerPosition()
    {
        // Resetowanie pozycji gracza
        CharacterController controller = GetComponent<CharacterController>();

        if (controller != null)
        {
            controller.enabled = false; // Wy��czanie CharacterController przed zmian� pozycji
            transform.position = startPosition;
            controller.enabled = true;  // W��czanie CharacterController po zmianie pozycji
        }
        else
        {
            transform.position = startPosition; // Je�li nie ma CharacterController
        }
    }
}
