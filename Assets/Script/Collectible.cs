using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;
using UnityEditor.Build.Content;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class Collectible : MonoBehaviour
{
    private AudioSource pickUpSound;

    // Start is called before the first frame update
    void Start()
    {
        pickUpSound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        var movementController = collision.gameObject.GetComponent<MovementController>();

        if (movementController != null)
        {
            movementController.scoreValue += 1;
            Debug.Log("Zbieranie przedmiotu! Nowy wynik: " + movementController.scoreValue);
        }

        pickUpSound = GameObject.Find("soundCollectible").GetComponent<AudioSource>();
        pickUpSound.Play();
        gameObject.SetActive(false);

        if (movementController.scoreValue == 4)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }


    private void RotateCollectible()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 90 * Time.deltaTime);
    }

    void Update()
    {
        RotateCollectible();
    }
}
