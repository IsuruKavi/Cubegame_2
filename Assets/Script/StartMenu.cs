
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{ 
    public void SelectLevel()
    {
        SceneManager.LoadScene(8);
    }
    public void GameQuit()
    { 
        Application.Quit();
    }
}
