using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public string nextlevel;

    private void OnCollisionEnter2D(Collision2D Player)
    {
        SceneManager.LoadScene(nextlevel);
    }
    
}
