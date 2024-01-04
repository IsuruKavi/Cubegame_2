using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour {

	//public static LevelControlScript instance = null;
	
	int sceneIndex, levelPassed;

	// Use this for initialization
	

	public void youWin()
	{
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        if (levelPassed < sceneIndex)
				PlayerPrefs.SetInt ("LevelPassed", sceneIndex);	
	}

	

	

	
}
