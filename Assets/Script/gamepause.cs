using UnityEngine;
public class gamepause : MonoBehaviour
{
    public GameObject conBtn;
    public GameObject countActive;
    public void gamePause()
    {
        Time.timeScale = 0f;
        conBtn.SetActive(true);
    }
    public void gamecontinue()
    {
        Time.timeScale = 1f;
        conBtn.SetActive(false);
        countActive.SetActive(true);
        
    }
}
