using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static WinLevel1;

public class ObjectsSpawner : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject needTheCat;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObjects());
    }
    IEnumerator SpawnObjects()
    {
        while (true)
        {
            if(ending){
                yield break;
            }
            int num = Random.Range(0, 3);
            if (num == 0){
                GameObject obj1 = Instantiate(object1);
                obj1.transform.position = new Vector3(12.18f, needTheCat.transform.position.y -0.5f, -0.5f);
            }
            if (num == 1){
                GameObject obj2 = Instantiate(object2);
                obj2.transform.position = new Vector3(12.18f, needTheCat.transform.position.y -0.5f, -0.5f);
            }
            if (num == 2){
                GameObject obj3 = Instantiate(object3);
                obj3.transform.position = new Vector3(12.18f, needTheCat.transform.position.y -0.35f, -0.5f);
            }
            yield return new WaitForSeconds(Random.Range(1, 3.5f));
        }
        
    }
}
