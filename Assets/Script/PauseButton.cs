using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject pauseMenu;
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }


}