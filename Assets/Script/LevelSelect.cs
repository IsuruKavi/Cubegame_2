using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
   public void LoadLevel01()
   {
      SceneManager.LoadScene("Level_1");
   }
   public void LoadLevel02()
   {
      SceneManager.LoadScene("Level_2");
   }
   public void LoadLevel03()
   {
      SceneManager.LoadScene("Level_3");
   }
   public void LoadLevel04()
   {
      SceneManager.LoadScene("Level_4");
   }
   public void LoadLevel05()
   {
      SceneManager.LoadScene("Level_5");
   }
}
