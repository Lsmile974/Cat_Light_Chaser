using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WinLevel1 : MonoBehaviour
{
    public static bool ending = false;
    private bool win = false;
    public GameObject winMenu;
    void Start(){
        win = false;
        ending = false;
        StartCoroutine(WaitForWin());
    }
    void Update(){
        if(win){
            Time.timeScale = 0;
            winMenu.SetActive(true);
        }
    }
    IEnumerator WaitForWin(){
        yield return new WaitForSeconds(77);
        ending = true;
        yield return new WaitForSeconds(10);
        win = true;
        yield break;
    }
}
