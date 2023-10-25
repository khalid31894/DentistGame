using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    public static void SetHighScore(int score)
    {
        PlayerPrefs.SetInt(PlayerPrefsKeys.HighScore, score);
        PlayerPrefs.Save();
    }
    // Example method to get the high score
    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt(PlayerPrefsKeys.HighScore, 0);
    }


    ///////////////////////////////////////////////////////////////////

    public static void SetPrivacySplash(bool confirmed)
    {
        if (confirmed)
        {
            PlayerPrefs.SetInt(PlayerPrefsKeys.PrivacySplashAccept, 1);
        }
        else
        {
            PlayerPrefs.SetInt(PlayerPrefsKeys.PrivacySplashAccept, 0);
        }
    }
    public static bool GetPrivacySplash()
    {
        if (PlayerPrefs.GetInt(PlayerPrefsKeys.PrivacySplashAccept) == 1)
        {
            return true;
        }
        else { return false; }

    }

    ///////////////////////////////////////////////////////////////////

    public static void SetCurrentCanvas(int canvasNumber)
    {
        PlayerPrefs.SetInt(PlayerPrefsKeys.CurrentCanvas, canvasNumber);

    }
    public static int GetCurrentCanvas()
    {
        return PlayerPrefs.GetInt(PlayerPrefsKeys.CurrentCanvas);
    }

    ////////////////////////////////////////////////////////////////



    void sendLogs<T>(T data)
    {
        Debug.Log($"PlayerPrefs Updated: {data.ToString()}");
    }
}
