using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // Gracz (musisz przypisaæ ten obiekt w Inspectorze)
    public float moveSpeed = 2.0f; // Prêdkoœæ chodzenia
    public float runSpeedMultiplier = 2.0f; // Mno¿nik prêdkoœci podczas biegu
    public float rotationSpeed = 5.0f; // Szybkoœæ rotacji
    private Animator animator; // Animator postaci
    public float followRange = 10.0f; // Zasiêg, w którym przeciwnik zaczyna œledziæ gracza
    private bool isFollowing = false; // Flaga, czy przeciwnik œciga gracza

    void Start()
    {
        // Pobieranie komponentu Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player != null)
        {
            // Obliczanie odleg³oœci do gracza
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // Sprawdzamy, czy gracz jest w zasiêgu
            if (distanceToPlayer <= followRange)
            {
                isFollowing = true; // Jeœli w zasiêgu, œcigamy gracza
            }
            else
            {
                isFollowing = false; // Jeœli poza zasiêgiem, nie œcigamy
            }

            // Je¿eli przeciwnik œciga gracza
            if (isFollowing)
            {
                // Obliczanie kierunku do gracza
                Vector3 direction = (player.position - transform.position).normalized;

                // Obracanie postaci w stronê gracza
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

                // Sprawdzenie, czy gracz jest blisko i wybranie prêdkoœci
                float currentMoveSpeed = moveSpeed;
                if (distanceToPlayer < 10.0f)
                {
                    currentMoveSpeed *= runSpeedMultiplier; // Gracz biegnie, jeœli blisko
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
            else
            {
                // Mo¿esz dodaæ tu animacjê, ¿e przeciwnik wraca do strefy patrolu lub staje w miejscu
                if (animator != null)
                {
                    animator.SetFloat("speed", 0); // Zatrzymanie animacji, gdy nie œciga gracza
                }
            }
        }
    }
}
