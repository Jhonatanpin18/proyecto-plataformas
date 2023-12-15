using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsMenu : MonoBehaviour
{
    public void openlevel(int levelid)
    {
        string levelname = "level " + levelid;
        SceneManager.LoadScene(levelname);
    }
}
