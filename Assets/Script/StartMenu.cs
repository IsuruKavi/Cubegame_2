using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void SelectLevel()
    {
        SceneManager.LoadScene(8);
        
    }
    public void GameQuit()
    {
        Application.Quit();
    }
}
