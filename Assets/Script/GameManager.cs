using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void tableCollectibles()
    {
        GameObject[] collectibles = GameObject.FindGameObjectsWithTag("Collectibles");
        int maxScore = collectibles.Length;
        Debug.Log("Total collectibles: " + maxScore);

    }

    // Update is called once per frame
    void Update()
    {
        tableCollectibles();
    }
}
