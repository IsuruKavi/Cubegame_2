using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
   public GameManager gameManager;
   public GameObject pauseBtn;
   public LevelControlScript levelControlScript;
   public AudioClip levelComplete;
   private AudioSource _audioSource;



   private void OnTriggerEnter(Collider other)
   {
      levelControlScript.youWin();
      gameManager.completeLevel();
      pauseBtn.SetActive(false);
      PlayLevelPassSound();
   }

   public void PlayLevelPassSound()
   {
      _audioSource = GetComponent<AudioSource>();
      _audioSource.PlayOneShot(levelComplete, 1f);
   }

   
     
   
   

}



   

