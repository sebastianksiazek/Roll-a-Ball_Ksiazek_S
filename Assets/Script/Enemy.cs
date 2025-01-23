using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // Gracz (musisz przypisaæ ten obiekt w Inspectorze)
    public float moveSpeed = 2.0f; // Prêdkoœæ chodzenia
    public float runSpeedMultiplier = 2.0f; // Mno¿nik prêdkoœci podczas biegu
    public float rotationSpeed = 5.0f; // Szybkoœæ rotacji
    private Animator animator; // Animator postaci

    void Start()
    {
        // Pobieranie komponentu Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Sprawdzenie, czy gracz jest w pobli¿u
        if (player != null)
        {
            // Obliczanie kierunku do gracza
            Vector3 direction = (player.position - transform.position).normalized;

            // Obracanie postaci w stronê gracza
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Sprawdzenie, czy gracz jest blisko i wybranie prêdkoœci
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            float currentMoveSpeed = moveSpeed;

            // Je¿eli gracz jest blisko, postaæ zaczyna biec
            if (distanceToPlayer < 10.0f)
            {
                currentMoveSpeed *= runSpeedMultiplier;
            }

            // Ruch w kierunku gracza
            Vector3 movement = direction * currentMoveSpeed * Time.deltaTime;
            transform.Translate(movement, Space.World);

            // Animacja chodzenia
            if (animator != null)
            {
                // Zmieniamy prêdkoœæ animacji w zale¿noœci od ruchu
                float animationSpeed = Mathf.Abs(currentMoveSpeed);
                animator.SetFloat("speed", animationSpeed);
            }
        }
    }
}
