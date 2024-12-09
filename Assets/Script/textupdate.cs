using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class textupdate : MonoBehaviour
{
    public GameObject player;  // Referencja do gracza
    public Text scoreText;  // Referencja do komponentu tekstu

    private MovementController movementController;  // Referencja do komponentu gracza

    void Start()
    {
        if (player != null)
        {
            movementController = player.GetComponent<MovementController>();

            if (movementController == null)
            {
                Debug.LogError("Brak komponentu MovementController na obiekcie gracza!");
            }
        }
        else
        {
            Debug.LogError("Gracz nie jest przypisany w inspektorze!");
        }
    }

    void Update()
    {
        if (movementController != null && scoreText != null)
        {
            // Aktualizowanie tekstu z aktualn¹ wartoœci¹ scoreValue
            scoreText.text = "Score: " + movementController.scoreValue.ToString();
        }
        else
        {
            if (movementController == null)
            {
                Debug.LogError("MovementController jest nullem.");
            }

            if (scoreText == null)
            {
                Debug.LogError("scoreText jest nullem.");
            }
        }
    }
}
