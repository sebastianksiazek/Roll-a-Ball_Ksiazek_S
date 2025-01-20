using UnityEngine;

public class wahadlo1 : MonoBehaviour
{
    public float amplitude = 45f;    // Maksymalny kąt wychylenia
    public float speed = 2f;         // Prędkość wahadła

    private Quaternion startRotation;

    void Start()
    {
        startRotation = transform.localRotation;
    }

    void Update()
    {
        float angle = amplitude * Mathf.Sin(Time.time * speed);
        // Obracamy tylko wokół osi Y dla ruchu lewo-prawo
        transform.localRotation = startRotation * Quaternion.Euler(0, angle, 0);
    }
}