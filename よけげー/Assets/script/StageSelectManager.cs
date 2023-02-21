using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour
{
    [SerializeField] private Button[] _stageButton;
    void Start()
    {
        int init = PlayerPrefs.GetInt("Init", 1);
        if (init == 1) { 
           PlayerPrefs.SetInt("UnlockStage", 1);
           PlayerPrefs.SetInt("Init", 2);
        }
       

        int stageUnlock = PlayerPrefs.GetInt("UnlockStage", 1);
        Debug.Log(init);
        for (int i = 0; i < _stageButton.Length; i++)
        {
            if (i < stageUnlock)
                _stageButton[i].interactable = true;
            else
                _stageButton[i].interactable = false;
        }
    }
    public void initgame()
    {
        PlayerPrefs.SetInt("UnlockStage", 1);
        SceneManager.LoadScene(0);
    }
    public void StageSelect(int stage)
    {
        SceneManager.LoadScene(stage);
        
    }
}