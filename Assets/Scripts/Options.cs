using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void PlaySelf()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
