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
        collision.gameObject.GetComponent<MovementController>().scoreValue += 1;
        Debug.Log("Score: " + collision.gameObject.GetComponent<MovementController>().scoreValue);
        pickUpSound = GameObject.Find("soundCollectible").GetComponent<AudioSource>();
        pickUpSound.Play(); // Play the sound when the collectible is picked up
        gameObject.SetActive(false);
        if (collision.gameObject.GetComponent<MovementController>().scoreValue == 4)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 90 * Time.deltaTime);
    }
}
