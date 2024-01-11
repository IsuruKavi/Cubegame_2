using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
   public  GameObject menuUI;
   public GameObject pauseBtnUI;
   public GameObject scoreUI;
   public AudioClip menuSound;
   private AudioSource menuTapSound;
   public void ShowMenu()
   {  
      FindObjectOfType<AudioManager>().Play("ButtonclickSound");
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
      FindObjectOfType<AudioManager>().Play("ButtonclickSound");
   }

   public void Restart()
   {
      
      SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
      FindObjectOfType<AudioManager>().Play("ButtonclickSound");
   }

   public void Quit()
   {
      Application.Quit();
      FindObjectOfType<AudioManager>().Play("ButtonclickSound");
   }
    public void Menu()
    {  
       SceneManager.LoadSceneAsync(7);
       FindObjectOfType<AudioManager>().Play("ButtonclickSound");
      
       
       
    }

    

   

}
