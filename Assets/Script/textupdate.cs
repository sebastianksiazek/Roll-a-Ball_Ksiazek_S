using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class textupdate : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;   
    public Text koniecgry;    

    private MovementController movementController; 

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
    }

    void Update()
    {
        if (movementController != null && scoreText != null)
        {
            scoreText.text = "Score: " + movementController.scoreValue.ToString();
            if (movementController.scoreValue >= 4)
            {
                if (koniecgry != null)
                {
                    //Invoke("Koniec Gry!", 1.5f);
                    koniecgry.text = "Koniec Gry!";
                }


            }
        }
    }
}
