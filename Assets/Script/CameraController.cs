using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraContoller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 vector;
    [SerializeField]
    public GameObject Player;
    void Start()
    {
        vector = Player.transform.position - transform.position;
    }
    private void CameraUpdate()
    {
        transform.position = Player.transform.position - vector;
    }

    // Update is called once per frame
    void Update()
    {
        CameraUpdate();
    }
}
