using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CatTrigger;

public class GameOver : MonoBehaviour
{
    private bool once =true;
    public GameObject deathMenu;
    public AudioSource levelMusic;
    public AudioSource deathMusic;
    void Start(){
        once = true;
    }
    void Update()
    {
        if(gameIsOver && once){
            Over();
            once = false;
        }
    }
    void Over(){
        Time.timeScale = 0;
        deathMenu.SetActive(true);
        levelMusic.Stop();
        deathMusic.Play();
    }
}
