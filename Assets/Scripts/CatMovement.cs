using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static PauseMenu;

public class CatMovement : MonoBehaviour
{
    public GameObject laser;
    public GameObject cat;
    public bool isMoving = false;
    void Update()
    {
        if (cat.transform.position.y != laser.transform.position.y -0.5f && !gamePaused && !isMoving){
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait(){
        isMoving = true;
        Debug.Log("Avant");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Après");
        cat.transform.position = new Vector3(cat.transform.position.x, laser.transform.position.y -0.5f, cat.transform.position.z);
        isMoving = false; 
        yield break;
    }
}
