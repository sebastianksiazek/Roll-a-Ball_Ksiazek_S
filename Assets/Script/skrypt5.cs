using UnityEngine;

public class skrypt5 : MonoBehaviour
{
    public Transform part1; // Obiekt platformy
    public float part1Speed = 2f; // Prędkość platformy
    private float part1Direction = 1f; // Kierunek ruchu (1 = w przód, -1 = w tył)

    public float minX = -104f; // Dolny limit osi Z
    public float maxX = -88f; // Górny limit osi Z

    void Update()
    {
        if (part1 == null)
        {
            Debug.LogError("Transform platformy nie jest przypisany!");
            return;
        }

        // Obecna pozycja platformy
        Vector3 currentPosition = part1.position;

        // Ruch tylko w osi Z
        float newZ = currentPosition.x + (part1Speed * part1Direction * Time.deltaTime);
        currentPosition.x = Mathf.Clamp(newZ, minX, maxX);

        // Aktualizowanie pozycji platformy
        part1.position = currentPosition;

        // Zmiana kierunku, jeśli osiągnięto granice
        if (currentPosition.x <= minX || currentPosition.x >= maxX)
        {
            part1Direction *= -1; // Zmiana kierunku
        }
    }
}