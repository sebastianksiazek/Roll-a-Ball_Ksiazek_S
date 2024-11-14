using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {

        //scoreValue += 1;
        collision.gameObject.GetComponent<MovementController>().scoreValue += 1;
        //Debug.Log("Score: " + collision.gameObject.GetComponent<MovementController>().scoreValue);
        gameObject.SetActive(false);
        if (collision.gameObject.GetComponent<MovementController>().scoreValue == 1)
        {
            Debug.Log("You win!");
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
