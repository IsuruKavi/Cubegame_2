using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour {

	int sceneIndex, levelPassed; 
	public void youWin()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void UnlockNextLevel()
	{    
		
		sceneIndex = SceneManager.GetActiveScene().buildIndex;
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		if (levelPassed < sceneIndex)
		{
			Debug.Log("Hi");
			PlayerPrefs.SetInt("LevelPassed", sceneIndex);
		}

	}
}
