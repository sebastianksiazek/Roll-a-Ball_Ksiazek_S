using UnityEngine;

public class skrypt5 : MonoBehaviour
{
    public Transform part1;
    public float part1Speed = 2f;
    private float part1Direction = 1f;

    public float minX = -104f;
    public float maxX = -88f;

    void Update()
    {
        if (part1 == null)
        {
            Debug.LogError("Transform platformy nie jest przypisany!");
            return;
        }
        Vector3 currentPosition = part1.position;
        float newZ = currentPosition.x + (part1Speed * part1Direction * Time.deltaTime);
        currentPosition.x = Mathf.Clamp(newZ, minX, maxX);
        part1.position = currentPosition;
        if (currentPosition.x <= minX || currentPosition.x >= maxX)
        {
            part1Direction *= -1;
        }
    }
}