using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        scoreValue += 1;
        collision.gameObject.GetComponent<MovementController>().scoreValue += 1;
        Debug.Log("Score: " + collision.gameObject.GetComponent<MovementController>().scoreValue);
        gameObject.SetActive(false);
        if (collision.gameObject.GetComponent<MovementController>().scoreValue == 4)
        {
           Debug.Log("You win!");
        }
        //score
    }
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 90 * Time.deltaTime);
    }
}
