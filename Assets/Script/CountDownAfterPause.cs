using System.Collections;
using TMPro;
using UnityEngine;

public class CountDownAfterPause : MonoBehaviour
{
    public int countDownTime=2;
    public TMP_Text countdownDisplay;
    
    public bool countOver = false;
    public GameObject score;
    public PauseMenuScript pauseMenuScript;
    public GameObject pauseBtn;
   

    private void Start()
    {   
        score.SetActive(false);
        pauseBtn.SetActive(false);
        countOver = false;
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
       
        while (countDownTime>0)
        {
            countdownDisplay.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }
        

        countdownDisplay.text = "Go!";
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);

        
        pauseMenuScript.menuActive = false;
        score.SetActive(true);
        pauseBtn.SetActive(true);
        countDownTime = 2;
        
        gameObject.SetActive(false);
        
        
      
      
      
    }
}