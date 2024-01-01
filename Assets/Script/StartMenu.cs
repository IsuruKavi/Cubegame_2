using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public  GameObject selectLevelUI;
    // Start is called before the first frame update
    public void SelectLevel()
    {
        Debug.Log("Play");
        
        selectLevelUI.SetActive(true);
        
    }
}
