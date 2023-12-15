using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject pauseIcon;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseIcon.SetActive(false);
        Time.timeScale = 0;
    }
    public void Home()
    {
        SceneManager.LoadScene("main menu");
        Time.timeScale = 1;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseIcon.SetActive(true);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
