using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 90 * Time.deltaTime);


    }
    private void OnTriggerEnter(Collider collision)
    {
       // Collision.collectives.GetComponent<MovementController>().score += 1;
    }
}
