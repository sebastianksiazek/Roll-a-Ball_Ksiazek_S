using UnityEngine;
using UnityEngine.SceneManagement;

public class end2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
