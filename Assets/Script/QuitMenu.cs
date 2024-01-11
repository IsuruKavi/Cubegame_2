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
        FindObjectOfType<AudioManager>().Play("TapPauseMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(7);
        FindObjectOfType<AudioManager>().Play("TapPauseMenu");
    }
}
    