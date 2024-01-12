using UnityEngine;

public class FinishedMoveScript : MonoBehaviour
{
    public float speed;
    public bool cameLeft;
   public bool cameRight;
    


    void FixedUpdate()
    {
        if (transform.position.x < -1.5)
        {
            cameLeft = true;
            cameRight = false;
        }
        else if (transform.position.x > 1.7)
        {
            cameLeft = false;
            cameRight = true;
        }

        if (cameLeft)
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);
        }
        if (cameRight)
        {
            transform.Translate(-speed*Time.deltaTime, 0, 0);
        }



    }

}
