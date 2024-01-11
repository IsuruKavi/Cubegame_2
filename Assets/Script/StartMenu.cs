
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    private AudioSource playClickSound;
    public AudioClip buttonClickSound;

    

    public void SelectLevel()
    {   
        FindObjectOfType<AudioManager>().Play("TapPauseMenu");
        SceneManager.LoadScene(7);
    }
    public void GameQuit()
    { 
        FindObjectOfType<AudioManager>().Play("TapPauseMenu");
        Application.Quit();
    }

    
}
