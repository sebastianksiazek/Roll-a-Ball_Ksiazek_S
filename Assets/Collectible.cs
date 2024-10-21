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
        if (collision != null)
        {
            gameObject.SetActive(false);
            scoreValue += 1;
        }

    }
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 90 * Time.deltaTime);
    }
}
