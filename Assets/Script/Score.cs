using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
   public TMP_Text scoreText;
   public float score = 0;

   public void AddScore()
   {
      score++;
      scoreText.text = score.ToString();
   }


}
