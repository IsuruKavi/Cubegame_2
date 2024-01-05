using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
   public  GameObject menuUI;
   public GameObject pauseBtnUI;
   public GameObject scoreUI;
   public void ShowMenu()
   {
      Time.timeScale = 0f;
      menuUI.SetActive(true);
      pauseBtnUI.SetActive(false);
      scoreUI.SetActive(false);
   }

   public void Continue()
   {
      Time.timeScale = 1f;
      menuUI.SetActive(false);
      pauseBtnUI.SetActive(true);
      scoreUI.SetActive(true);
   }

   public void Restart()
   {
      Time.timeScale = 1f;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void Quit()
   { 
      Application.Quit();
   }
    public void Menu()
    { 
       Time.timeScale = 1f; 
       SceneManager.LoadScene(8);
    }

}
