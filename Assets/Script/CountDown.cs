using System.Collections;
using TMPro;
using UnityEngine;


public class CountDown : MonoBehaviour
{
   public int countDownTime;
   public TMP_Text countdownDisplay;
   public TMP_Text levelDisplay;
   public GameObject score;
   public GameObject pauseMenu;
   public PlayerScirpt playerScirpt;
   
   

   private void Start()
   {
      Time.timeScale = 1f;
      StartCoroutine(CountdownToStart());
      playerScirpt.countOver = false;
      pauseMenu.SetActive(false);
      
      

   }

   IEnumerator CountdownToStart()
   {
      yield return new WaitForSeconds(1f);
      levelDisplay.gameObject.SetActive(false);
      while (countDownTime>0)
      {
         countdownDisplay.text = countDownTime.ToString();
         yield return new WaitForSeconds(1f);
         countDownTime--;
      }

      countdownDisplay.text = "Go!";
      yield return new WaitForSeconds(1f);
      countdownDisplay.gameObject.SetActive(false);

      
      score.SetActive(true);
      pauseMenu.SetActive(true);
      gameObject.SetActive(false);
      playerScirpt.countOver = true;
      
      
      
   }
}
