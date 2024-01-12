using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    private PlayerScirpt playerScirpt;
    private EndTrigger endTriggerScript;

    private void Start()
    {
        playerScirpt = GameObject.Find("Player").GetComponent<PlayerScirpt>();
        endTriggerScript = GameObject.Find("End").GetComponent<EndTrigger>();
    }

    void FixedUpdate()
    {   if(playerScirpt.countOver==true && playerScirpt.gameEnd==false && endTriggerScript.isFinishedGame==false)
        transform.Rotate(0,0,-300*Time.deltaTime);
    }
}
