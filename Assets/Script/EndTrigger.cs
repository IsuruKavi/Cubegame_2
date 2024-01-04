using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
   public GameManager gameManager;
   public GameObject pauseBtn;
    public LevelControlScript levelControlScript;



   private void OnTriggerEnter(Collider other)
   {
      gameManager.completeLevel();
      pauseBtn.SetActive(false);
       levelControlScript.youWin();
      
      


   }

   
     
   
   

}



   

