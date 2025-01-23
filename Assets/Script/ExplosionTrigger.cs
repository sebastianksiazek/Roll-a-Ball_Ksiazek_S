using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    public ParticleSystem explosionEffectPrefab;
    public float destructionDelay = 0.0f;
    private bool hasExploded = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasExploded)
        {
            hasExploded = true;
            if (explosionEffectPrefab != null)
            {
                ParticleSystem explosion = Instantiate(
                    explosionEffectPrefab,
                    transform.position,
                    Quaternion.identity
                );
                explosion.Play();
                Destroy(explosion.gameObject, explosion.main.duration + explosion.main.startLifetime.constantMax);
            }

            Destroy(gameObject, destructionDelay);
        }
    }
}
