using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeMoving : MonoBehaviour
{
    
    private Vector3 startUp;
    private Vector3 startMid;
    private Vector3 startDown;
    public GameObject Plateform;

    void Start()
    {
        startUp = new Vector3(12.18f, 3.75f, -0.2f);
        startMid = new Vector3(12.18f, 0.75f, -0.2f);
        startDown = new Vector3(12.18f, -2.25f, -0.2f);
        StartCoroutine(SpawnPlateform());
    }

void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    IEnumerator SpawnPlateform()
    {
        while (true)
        {
            GameObject plt1 = Instantiate(Plateform);
            plt1.transform.position = startUp;
            GameObject plt2 = Instantiate(Plateform);
            plt2.transform.position = startMid;
            GameObject plt3 = Instantiate(Plateform);
            plt3.transform.position = startDown;
            yield return new WaitForSeconds(2.3f);
        }
        
    }
}