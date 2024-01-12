using UnityEngine;

public class EndTrigger : MonoBehaviour
{
   public GameManager gameManager;
   public GameObject pauseBtn;
   public LevelControlScript levelControlScript;
   public AudioClip levelComplete;
   private AudioSource _audioSource;
   public bool isFinishedGame = false;



   public void OnTriggerEnter(Collider other)
   {
      
      gameManager.completeLevel();
      pauseBtn.SetActive(false);
      PlayLevelPassSound();
      isFinishedGame = true;
      levelControlScript.UnlockNextLevel();
   }

   public void PlayLevelPassSound()
   {
      _audioSource = GetComponent<AudioSource>();
      _audioSource.PlayOneShot(levelComplete, 1f);
   }

   
     
   
   

}



   

