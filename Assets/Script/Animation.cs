using UnityEngine;

public class Animation : MonoBehaviour
{

    [SerializeField] Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetTrigger("touch2");
        }
        else
        {
            Debug.Log("Nie dotkniêto gracza");
        }
    }
}
