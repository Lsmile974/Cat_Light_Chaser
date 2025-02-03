using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatTrigger : MonoBehaviour
{
    public static bool gameIsOver = false;
    void Start()
    {
        gameIsOver = false;
    }
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");
        gameObject.SetActive(false);
        gameIsOver = true;
    }
}
