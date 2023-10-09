using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScene : MonoBehaviour
{
    public void ChangerScene()
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(noScene + 1);
        if (noScene == 3)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void Quitter()
    {
        Application.Quit();
    }
    
}
