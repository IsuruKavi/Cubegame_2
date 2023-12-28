using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public GameObject completeLevelUI;
   public GameObject gameOverUI;
   public GameObject scoreUI;
   
   
   
   public void EndGame()
   {
      Debug.Log("GameOver");
      LoadGameOVerUI();
      
      
   }


   public void LoadGameOVerUI()
   {
      gameOverUI.SetActive(true);
      scoreUI.SetActive(false);
      
   }

   public void completeLevel()
   {
      Debug.Log("LevelComplete");
      completeLevelUI.SetActive(true);
      Invoke("LoadNextScene",1f);
      
   }

   void LoadNextScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
