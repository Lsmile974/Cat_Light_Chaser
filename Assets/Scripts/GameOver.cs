using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static CatTrigger;

public class GameOver : MonoBehaviour
{
    public GameObject deathMenu;
    public AudioSource levelMusic;
    public AudioSource deathMusic;
    void Update()
    {
        if(gameIsOver){
            Over();
        }
    }
    void Over(){
        Time.timeScale = 0;
        deathMenu.SetActive(true);
        levelMusic.Stop();
        deathMusic.Play();
    }
}
