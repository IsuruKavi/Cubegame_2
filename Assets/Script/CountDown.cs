
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
   public int countDownTime;
   public TMP_Text countdownDisplay;
   public TMP_Text levelDisplay;
   public bool countOver = false;
   public GameObject score;
   

   private void Start()
   {  
      StartCoroutine(CountdownToStart());
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

      countOver = true;
      score.SetActive(true);
      gameObject.SetActive(false);
      
      
      
   }
}
