using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemaneger : MonoBehaviour
{
    public GameObject gameoverUI;
    public GameObject gameclearUI;
    public GameObject gamestartUI;
    public GameObject gameposeUI;
    public rallplayer rallplayer;
    public StageManager stagemaneger;
 
    bool isgameclear = false;
    bool isgameover = false;
    bool isgamestop = true;
    bool isgamestart = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;  // éûä‘í‚é~
        gamestartUI.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey("space"))
        {
            if (isgamestop == true && isgamestart == false)
            {
                Time.timeScale = 1;  // çƒäJ
                rallplayer.Activeplayer();
                gamestartUI.SetActive(false);
                isgamestop = false;
                isgamestart = true;
            }
        }
        if (Input.GetKey("t"))
        {
            if (isgamestop == false)
            {
                gameposeUI.SetActive(true);
                Time.timeScale = 0;  // çƒäJ
                rallplayer.stopplayer();               
                isgamestop = true;
            }
        }
    }

    
    public void Gameclear()
    {
        Debug.Log("Game Clear");
        gameclearUI.SetActive(true);
        rallplayer.stopplayer();
        isgameclear = true;
        isgamestop = true;
        stagemaneger.Stageunlock();

    }

    public void Gameover()
    {
        Debug.Log("Game Over");
        gameoverUI.SetActive(true);
        rallplayer.stopplayer();
        isgameover = true;
        isgamestop = true;
    }
  
    public void Gamerestaet() 
    {
        Time.timeScale = 1;  // çƒäJ
        rallplayer.Activeplayer();
        gameposeUI.SetActive(false);
        isgamestop = false;
    }

}

