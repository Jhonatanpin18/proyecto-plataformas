using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public void playgame() 
    {
        SceneManager.LoadSceneAsync("level 1");       
    }

    public void quitgame()
    {
        Application.Quit();
    }

}
