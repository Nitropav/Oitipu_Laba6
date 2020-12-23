using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine;

public class Banner : MonoBehaviour
{
    public string id = "Banners";

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3941995", false);
        }
        StartCoroutine(ShowBanner());

    }

    IEnumerator ShowBanner()
    {

       while (!Advertisement.IsReady(id))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(id);

    }
}
