using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
