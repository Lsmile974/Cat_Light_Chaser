using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CatTrigger;
using static WinLevel1;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool gamePaused = false;
    public AudioSource levelMusic;
    public AudioSource pauseMusic;
    void Start(){
        Time.timeScale = 1;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !gameIsOver && !ending){
            if (gamePaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;
        levelMusic.Pause();
        pauseMusic.Play();
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
        pauseMusic.Stop();
        levelMusic.Play();
        
    }
}
