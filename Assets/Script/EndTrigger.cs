using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
   public GameManager gameManager;
   public GameObject pauseBtn;
   private int levelValue;



   private void OnTriggerEnter(Collider other)
   {
      gameManager.completeLevel();
      pauseBtn.SetActive(false);
      levelValue++;
      SetLevel(levelValue);
      Debug.Log(GetLevel());


   }

   
      public void SetLevel( int Value)
      {
         PlayerPrefs.SetInt("Level", 1);
      }

      public int GetLevel()
      {
         return PlayerPrefs.GetInt("Level");
      }
   
   

}



   

