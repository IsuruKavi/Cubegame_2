using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public bool pauseGame = false;

    private GameObject menuUI;
    // Start is called before the first frame update
    public void Pausegame()
    {
        pauseGame = true;
        menuUI.SetActive(true);

    }
    
}
