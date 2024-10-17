using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraContoller : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    public GameObject Player;
    void Start()
    {
        //testttttttttttttttttttttttttttttttttt
        offset = Player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    { 

        transform.position = Player.transform.position - offset;

    }
}
