using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2.0f;
    public float runSpeedMultiplier = 2.0f;
    public float rotationSpeed = 5.0f;
    private Animator animator;
    public float followRange = 10.0f;
    private bool isFollowing = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            if (distanceToPlayer <= followRange)
            {
                isFollowing = true;
            }
            else
            {
                isFollowing = false;
            }

            if (isFollowing)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

                float currentMoveSpeed = moveSpeed;
                if (distanceToPlayer < 10.0f)
                {
                    currentMoveSpeed *= runSpeedMultiplier;
                }

                Vector3 movement = direction * currentMoveSpeed * Time.deltaTime;
                transform.Translate(movement, Space.World);

                if (animator != null)
                {
                    float animationSpeed = Mathf.Abs(currentMoveSpeed);
                    animator.SetFloat("speed", animationSpeed);
                }
            }
            else
            {
                if (animator != null)
                {
                    animator.SetFloat("speed", 0);
                }
            }
        }
    }
}
