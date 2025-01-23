using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    public ParticleSystem explosionEffectPrefab; // Prefab cz¹steczek
    public float destructionDelay = 0.0f; // Opcjonalne opóŸnienie przed zniszczeniem obiektu
    private bool hasExploded = false; // Flaga, aby unikn¹æ wielokrotnego wywo³ania

    void OnTriggerEnter(Collider other)
    {
        // Sprawdzenie, czy gracz dotkn¹³ obiektu
        if (other.CompareTag("Player") && !hasExploded)
        {
            hasExploded = true;

            // Tworzenie efektu cz¹steczek w miejscu obiektu
            if (explosionEffectPrefab != null)
            {
                // Instantiate prefab na pozycji obiektu
                ParticleSystem explosion = Instantiate(
                    explosionEffectPrefab,
                    transform.position,
                    Quaternion.identity
                );

                // Uruchomienie efektu
                explosion.Play();

                // Zniszczenie prefabrykat cz¹steczek po zakoñczeniu efektu
                Destroy(explosion.gameObject, explosion.main.duration + explosion.main.startLifetime.constantMax);
            }

            // Zniszczenie obiektu
            Destroy(gameObject, destructionDelay);
        }
    }
}
