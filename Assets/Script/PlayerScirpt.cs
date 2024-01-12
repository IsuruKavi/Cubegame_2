using UnityEngine;

public class PlayerScirpt : MonoBehaviour
{
    private Rigidbody playerRb;
    private float touchspeed =0.01f;
    private Touch touch;
    private float xrange=9.41f;
    private AudioSource playerAudio;
    
    public bool gameEnd=false ;
    public GameManager GameManager;
    public Score Score;
    public float speed;
    public CountDown countDown;
    public GameObject scoreUI;
    public bool countOver = false;
    public AudioClip friendCrashSound;
    public AudioClip enemyCrashSound;
    private EndTrigger endTriggerScript;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        scoreUI.SetActive(false);
        playerAudio = GetComponent<AudioSource>();
        endTriggerScript = GameObject.Find("End").GetComponent<EndTrigger>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (countOver == true)
        { 
            if (gameEnd == false && endTriggerScript.isFinishedGame==false)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                TouchControll();
            }
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
            playerAudio.PlayOneShot(friendCrashSound,1.0f);
        }
        if (other.gameObject.CompareTag("EnemyObs"))
        {
            playerAudio.PlayOneShot(enemyCrashSound,1.0f);
            Debug.Log("Enemy");
            gameEnd = true;
            GameManager.EndGame();
        }
    }

    
}
