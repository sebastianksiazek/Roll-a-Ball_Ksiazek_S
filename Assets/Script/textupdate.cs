using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;
using UnityEditor.Build.Content;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class textupdate : MonoBehaviour
{
    public int scoreValue;
    public Text text;
    public Text koniecgry;
    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text = GetComponent<Text>();
    }
    // void onCollisionEnter(Collision collision)
    //  {
    //  collision.gameObject.GetComponent<MovementController>().scoreValue += 1;
    //  Debug.Log("Score: " + collision.gameObject.GetComponent<MovementController>().scoreValue);
    //  text.text = "Score: " + scoreValue;
    //   if (scoreValue == 4)
    // {
    //     koniecgry.text = "Koniec Gry!";
    //}
    //  }

    // Update is called once per frame
    void Update()
    {
        // CollectScore();
    }
}
