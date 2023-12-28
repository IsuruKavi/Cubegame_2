using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    private PlayerScirpt PlayerControllScirpt;
    public GameObject player;

    private Vector3 position;
    
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        Debug.Log(position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + position;
       
    }
    
    
    
    
    
}
