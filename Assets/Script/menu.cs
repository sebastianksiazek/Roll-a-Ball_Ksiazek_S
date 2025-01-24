using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    // Update is called once per frame
    public void ShowOptions()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
