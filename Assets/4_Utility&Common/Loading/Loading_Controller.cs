using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Loading_Controller : MonoBehaviour
{
    private bool isFirstUpdate = true;
    [SerializeField] float loadingTime = 3.0f;
    public static bool showMeAd = false;
    private void Update()
    {
        if (isFirstUpdate)
        {
            isFirstUpdate = false;
            StartCoroutine(waitTime());
        }


    }

    IEnumerator waitTime()
    {
        if (!showMeAd)
        {
            yield return new WaitForSeconds(loadingTime);
            SceneLoader.LoaderCallBack();
        }

        if (showMeAd)
        {
            yield return new WaitForSeconds(loadingTime/2);
            //if (IntitializeAdmobAds_CB._instance)
            //{
            //    IntitializeAdmobAds_CB._instance.ShowAdmobInterstialAd();
            //}
            yield return new WaitForSeconds(loadingTime/2);
            showMeAd = false;
            SceneLoader.LoaderCallBack();
        }
    }

}
