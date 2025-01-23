using UnityEngine;

public class animation2 : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float runSpeedMultiplier = 2.0f; // Mno¿nik prêdkoœci podczas biegu
    public float rotateSpeed = 100.0f;
    private Animator animator;

    void Start()
    {
        // Pobranie komponentu Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Odczytanie informacji steruj¹cych z klawiatury
        float h = Input.GetAxis("Horizontal"); // Ruch w lewo/prawo
        float v = Input.GetAxis("Vertical");   // Ruch w przód/ty³

        // Sprawdzenie, czy klawisz Ctrl jest wciœniêty
        bool isRunning = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);

        // Aktualizacja prêdkoœci ruchu
        float currentMoveSpeed = moveSpeed;
        if (isRunning && v > 0)
        {
            currentMoveSpeed *= runSpeedMultiplier;
        }

        // Ruch postaci
        Vector3 movement = new Vector3(0, 0, v * currentMoveSpeed * Time.deltaTime);
        transform.Translate(movement);

        // Rotacja postaci
        transform.Rotate(0, h * rotateSpeed * Time.deltaTime, 0);

        if (animator != null)
        {
            // Ustawienie parametru "speed" w Animatorze
            float animationSpeed = Mathf.Abs(v);
            if (isRunning && v > 0)
            {
                animationSpeed = 2.0f; // Wartoœæ dla animacji biegu
            }
            animator.SetFloat("speed", animationSpeed);

            // Wyzwolenie animacji skoku
            if (Input.GetButtonDown("Jump"))
            {
                animator.SetTrigger("jump");
            }
        }
    }
}
