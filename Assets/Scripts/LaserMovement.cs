using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pointeur_Move : MonoBehaviour
{
    public int Floor = 1;
    public bool MoveUp = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Floor == 2){
                MoveUp = false;
            }
            if (Floor == 0){
                MoveUp = true;
            }
            if (MoveUp){
                Floor += 1;
                transform.position = new Vector3(transform.position.x, transform.position.y +3, transform.position.z);
            }
            else{
                Floor -= 1;
                transform.position = new Vector3(transform.position.x, transform.position.y -3, transform.position.z);
            }
            Debug.Log("Space key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space key was released.");
        }  
    }
}
