using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Xml.Serialization;

public class MovementController : MonoBehaviour
{
    public Text text;
    public Text koniecgry;
    public int scoreValue;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void GetInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition);
        };
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D key was pressed");
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 2, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 2, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 2, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 2 ,ForceMode.Force);
        }
    }



    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

}
