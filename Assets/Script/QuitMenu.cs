using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{
    public void Quit()
    {   
        Debug.Log("Quit");
        Application.Quit();
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("StartWindow");
    }
}
