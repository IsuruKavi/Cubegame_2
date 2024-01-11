using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    private PlayerScirpt playerScirpt;

    private void Start()
    {
        playerScirpt = GameObject.Find("Player").GetComponent<PlayerScirpt>();
    }

    void FixedUpdate()
    {   if(playerScirpt.countOver==true && playerScirpt.gameEnd==false)
        transform.Rotate(0,0,300*Time.deltaTime);
    }
}
