using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeMoving : MonoBehaviour
{
    public float scrollSpeed = 2f;
    private Vector3 startPos;
    public GameObject Plateform;

    void Start()
    {
        startPos = Plateform.transform.position;
    }

    void Update()
    {
        Plateform.transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        if (Plateform.transform.position.x < -8.57)
        {
            Plateform.transform.position = startPos;
        }
    }
}