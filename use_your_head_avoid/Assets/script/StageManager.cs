using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{

    public int Max = 10;
    public Transport transport;

    public void Stageunlock()
    {
        int StageUnlock = PlayerPrefs.GetInt("UnlockStage");
        int NextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (NextScene < Max)
        {
            if (StageUnlock < NextScene)
            {
                PlayerPrefs.SetInt("UnlockStage", NextScene);
            }

        }
    }
   
    public void NextStage()
    {
        int NextScene = SceneManager.GetActiveScene().buildIndex + 1;
        transport.OnDestroy();
        SceneManager.LoadScene(NextScene);
    }

    public void ReturnTitle()
    {
        transport.OnDestroy();
        SceneManager.LoadScene(0);

    }

    public void GameRetry()
    {
        int NowScene = SceneManager.GetActiveScene().buildIndex;
        transport.OnDestroy();
        SceneManager.LoadScene(NowScene);
    }
}