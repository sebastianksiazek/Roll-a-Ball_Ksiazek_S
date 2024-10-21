using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraContoller : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 vector;
    public GameObject Player;
    void Start()
    {
        vector = Player.transform.position - transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position - vector;
    }//test
}
