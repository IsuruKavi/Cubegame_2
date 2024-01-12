using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public GameObject completeLevelUI;
   public GameObject gameOverUI;
   public GameObject scoreUI;
   public GameObject pauseBtnUI;
  
   
   
   public void EndGame()
   {
      
      LoadGameOVerUI();
      pauseBtnUI.SetActive(false);


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
     
      
   }

   void LoadNextScene()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
