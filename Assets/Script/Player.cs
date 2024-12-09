using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Xml.Serialization;

public class Player : MonoBehaviour
{
    public Text text;
    public Text koniecgry;
    public int scoreValue;
    public Rigidbody rb;
    private object collision;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CollectScore();
    }

    public void CollectScore()
    {
        text.text = "Score: " + scoreValue;
        scoreValue += 1;
        text.text = "Score: " + scoreValue;
        if (scoreValue == 4)
        {
            koniecgry.text = "Koniec Gry!";
        }
    }

}
