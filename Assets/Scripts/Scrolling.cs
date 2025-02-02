using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMoving : MonoBehaviour
{
    public float scrollSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        if (transform.position.x < -8.57)
        {
            Destroy(gameObject);
        }
    }
}