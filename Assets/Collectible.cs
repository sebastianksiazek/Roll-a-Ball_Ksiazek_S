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

        }
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        //scoreValue += 1;
        collision.gameObject.GetComponent<MovementController>().scoreValue += 1;
        Debug.Log("Score: " + collision.gameObject.GetComponent<MovementController>().scoreValue);
        GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
        if (collision.gameObject.GetComponent<MovementController>().scoreValue == 4)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
        pickUpSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 90 * Time.deltaTime);
    }
}
