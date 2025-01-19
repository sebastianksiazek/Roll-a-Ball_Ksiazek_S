using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private AudioSource pickUpSound;
    public static event Action pickupEvent;

    private void Start()
    {
        pickUpSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        var movementController = collision.gameObject.GetComponent<MovementController>();

        if (movementController != null)
        {
            pickupEvent?.Invoke();

            Debug.Log("Zbieranie przedmiotu!");
            pickUpSound = GameObject.Find("soundCollectible").GetComponent<AudioSource>();
            pickUpSound.Play();
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        RotateCollectible();
    }

    private void RotateCollectible()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 90 * Time.deltaTime);
    }
}

