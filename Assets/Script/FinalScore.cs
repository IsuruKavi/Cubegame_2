using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
   public TMP_Text finalScore;
   public Score scoretext;

   public void display()
   { Debug.Log("1");
      
     Debug.Log("2");
      finalScore.text = "Score: " + scoretext.score.ToString();
   }
  
}
