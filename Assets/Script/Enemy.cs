using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // Gracz (musisz przypisa� ten obiekt w Inspectorze)
    public float moveSpeed = 2.0f; // Pr�dko�� chodzenia
    public float runSpeedMultiplier = 2.0f; // Mno�nik pr�dko�ci podczas biegu
    public float rotationSpeed = 5.0f; // Szybko�� rotacji
    private Animator animator; // Animator postaci
    public float followRange = 10.0f; // Zasi�g, w kt�rym przeciwnik zaczyna �ledzi� gracza
    private bool isFollowing = false; // Flaga, czy przeciwnik �ciga gracza

    void Start()
    {
        // Pobieranie komponentu Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player != null)
        {
            // Obliczanie odleg�o�ci do gracza
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // Sprawdzamy, czy gracz jest w zasi�gu
            if (distanceToPlayer <= followRange)
            {
                isFollowing = true; // Je�li w zasi�gu, �cigamy gracza
            }
            else
            {
                isFollowing = false; // Je�li poza zasi�giem, nie �cigamy
            }

            // Je�eli przeciwnik �ciga gracza
            if (isFollowing)
            {
                // Obliczanie kierunku do gracza
                Vector3 direction = (player.position - transform.position).normalized;

                // Obracanie postaci w stron� gracza
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

                // Sprawdzenie, czy gracz jest blisko i wybranie pr�dko�ci
                float currentMoveSpeed = moveSpeed;
                if (distanceToPlayer < 10.0f)
                {
                    currentMoveSpeed *= runSpeedMultiplier; // Gracz biegnie, je�li blisko
                }

                // Ruch w kierunku gracza
                Vector3 movement = direction * currentMoveSpeed * Time.deltaTime;
                transform.Translate(movement, Space.World);

                // Animacja chodzenia
                if (animator != null)
                {
                    // Zmieniamy pr�dko�� animacji w zale�no�ci od ruchu
                    float animationSpeed = Mathf.Abs(currentMoveSpeed);
                    animator.SetFloat("speed", animationSpeed);
                }
            }
            else
            {
                // Mo�esz doda� tu animacj�, �e przeciwnik wraca do strefy patrolu lub staje w miejscu
                if (animator != null)
                {
                    animator.SetFloat("speed", 0); // Zatrzymanie animacji, gdy nie �ciga gracza
                }
            }
        }
    }
}
