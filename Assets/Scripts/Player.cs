using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject restart, gameover;
     


    void Awake ()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3941995", false);
        }
        lose = false;
       
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show("video");
            }
            Destroy(gameObject);
            lose = true;
            restart.SetActive (true);
            gameover.SetActive (true);
        }
    }

}
