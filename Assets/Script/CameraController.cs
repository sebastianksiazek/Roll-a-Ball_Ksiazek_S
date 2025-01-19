using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Vector3 vector;
    [SerializeField]
    public GameObject Player;

    private void Start()
    {
        vector = Player.transform.position - transform.position;
    }

    private void CameraUpdate()
    {
        transform.position = Player.transform.position - vector;
    }

    private void Update()
    {
        CameraUpdate();
    }
}

