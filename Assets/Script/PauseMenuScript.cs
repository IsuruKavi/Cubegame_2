using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
   public  GameObject menuUI;
   public GameObject pauseBtnUI;
   public bool menuActive=false;
   public GameObject scoreUI;
   public GameObject countdownUI;
   public GameObject count1;

   public void ShowMenu()
   {
      
      menuUI.SetActive(true);
      pauseBtnUI.SetActive(false);
      scoreUI.SetActive(false);
      Time.timeScale = 0f;

   }

   public void Continue()
   {
      menuUI.SetActive(false);
      // count1.SetActive(true);
      // countdownUI.SetActive(true);
      pauseBtnUI.SetActive(true);
      scoreUI.SetActive(true);
      Time.timeScale = 1f;


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
    {   Time.timeScale = 1f;
        SceneManager.LoadScene(8);
    }

}
