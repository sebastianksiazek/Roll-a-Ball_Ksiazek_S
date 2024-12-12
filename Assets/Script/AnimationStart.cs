/*using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationStart : MonoBehaviour
{
    public Animator animator; 

    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator nie zosta³ znaleziony na obiekcie " + gameObject.name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Gracz dotkn¹³ triggera!"); 
            animator.SetTrigger("PlayAnimation"); 
        }
    }
}
*/