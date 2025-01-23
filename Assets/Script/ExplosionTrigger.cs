using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    public ParticleSystem explosionEffectPrefab; // Prefab cz�steczek
    public float destructionDelay = 0.0f; // Opcjonalne op�nienie przed zniszczeniem obiektu
    private bool hasExploded = false; // Flaga, aby unikn�� wielokrotnego wywo�ania

    void OnTriggerEnter(Collider other)
    {
        // Sprawdzenie, czy gracz dotkn�� obiektu
        if (other.CompareTag("Player") && !hasExploded)
        {
            hasExploded = true;

            // Tworzenie efektu cz�steczek w miejscu obiektu
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

                // Zniszczenie prefabrykat cz�steczek po zako�czeniu efektu
                Destroy(explosion.gameObject, explosion.main.duration + explosion.main.startLifetime.constantMax);
            }

            // Zniszczenie obiektu
            Destroy(gameObject, destructionDelay);
        }
    }
}
