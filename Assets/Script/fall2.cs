using UnityEngine;

public class fall2 : MonoBehaviour
{
    public Vector3 startPosition; // Punkt startowy gracza

    private void Start()
    {
        // Zapisanie pocz¹tkowej pozycji gracza
        //startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdzamy, z czym gracz wchodzi w kolizjê
        Debug.Log("Wykryto kolizjê z: " + other.gameObject.name);

        // Sprawdzamy, czy kolizja jest z odpowiedni¹ platform¹
        if (other.gameObject.CompareTag("SafeZone2"))
        {
            Debug.Log("Dotkniêto SafeZone2! Resetowanie pozycji.");
            ResetPlayerPosition();
        }
    }


    private void ResetPlayerPosition()
    {
        // Resetowanie pozycji gracza
        CharacterController controller = GetComponent<CharacterController>();

        if (controller != null)
        {
            controller.enabled = false; // Wy³¹czanie CharacterController przed zmian¹ pozycji
            transform.position = startPosition;
            controller.enabled = true;  // W³¹czanie CharacterController po zmianie pozycji
        }
        else
        {
            transform.position = startPosition; // Jeœli nie ma CharacterController
        }
    }
}
