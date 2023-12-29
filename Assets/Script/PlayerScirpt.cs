using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScirpt : MonoBehaviour
{
    private Rigidbody playerRb;
    private float touchspeed =0.01f;
    private Touch touch;
    public bool gameover = false;
    public GameManager GameManager;
    private float xrange=9.41f;
    
    public Score Score;

    public float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameover == false)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            
            TouchControll();
        }
    }

    void TouchControll()
    {   
        if (transform.position.x > xrange )
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x <- xrange )
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= -xrange && transform.position.x <= xrange)
        {
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * touchspeed,
                        transform.position.y, transform.position.z );
                }
            }
        }
        
      

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FriendObs"))
        {
            
            Destroy(other.gameObject);
            Score.AddScore();
            
            
        }
        if (other.gameObject.CompareTag("EnemyObs"))
        {
            Debug.Log("Enemy");
            gameover = true;
            GameManager.EndGame();
           
            
    
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("FriendObs"))
        {
            
            Destroy(other.gameObject);
            Score.AddScore();
            
            
        }
        if (other.gameObject.CompareTag("EnemyObs"))
        {
            Debug.Log("Enemy");
            gameover = true;
            GameManager.EndGame();
            

        }
        
    }
}
