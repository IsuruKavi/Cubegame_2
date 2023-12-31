﻿
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManuControlScript : MonoBehaviour {

	public Button level02Button, level03Button, level04Button, level05Button;
	int levelPassed;

	// Use this for initialization
	void Start () {
		levelPassed = PlayerPrefs.GetInt ("LevelPassed");
		level02Button.interactable = false;
		level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;

        switch (levelPassed) {
		case 1:
			level02Button.interactable = true;
			    break;
		case 2:
			level02Button.interactable = true;
			level03Button.interactable = true;
			    break;
        case 3:
            level02Button.interactable = true;
            level03Button.interactable = true;
            level04Button.interactable = true;
                break;
        case 4:
	        level02Button.interactable = true;
	        level03Button.interactable = true;
	        level04Button.interactable = true;
	        level05Button.interactable = true;
                break;
        }
	}
	
	public void levelToLoad (int level)
	{
		SceneManager.LoadScene (level);
	}

	public void resetPlayerPrefs()
	{
		level02Button.interactable = false;
		level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;
        PlayerPrefs.DeleteAll ();
	}

	public void Back()
	{
		SceneManager.LoadScene(0);
	}
}
