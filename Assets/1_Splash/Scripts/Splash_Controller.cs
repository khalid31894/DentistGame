using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash_Controller : MonoBehaviour
{
    [SerializeField] private GameObject privacyPanel;
    [SerializeField] private GameObject splashPanel;
    [SerializeField] private float SplashTime = 4;

    void Start()
    {
        BeginSplash();
    }

    public void BeginSplash()
    {
        if (PlayerPrefsManager.GetPrivacySplash() == false)
        {
            privacyPanel.SetActive(true);
        }
        else
        {
            splashPanel.SetActive(true);
            StartCoroutine(ChangeScene());
        }
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(SplashTime);
        SceneManager.LoadScene(nameof(SceneLoader.Scenes.Scene2_Menu));
    }





    public void PrivacyAccept_Btn()
    {
        PlayerPrefsManager.SetPrivacySplash(true);
        privacyPanel.SetActive(false);
        splashPanel.SetActive(true);
        StartCoroutine(ChangeScene());

    }
    public void PrivacyPolicyView_Btn()
    {
        //Direct to URL
        Application.OpenURL("https://taptoy.io/privacy/");
    }

}
