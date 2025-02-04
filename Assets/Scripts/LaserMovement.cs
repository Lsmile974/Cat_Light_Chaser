using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static PauseMenu;

public class LaserMovement : MonoBehaviour
{
    public int Floor = 1;
    public bool MoveUp = true;
    public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && !gamePaused)
        {
            if (Floor == 2){
                MoveUp = false;
            }
            if (Floor == 0){
                MoveUp = true;
            }
            if (MoveUp){
                Floor += 1;
                laser.transform.position = new Vector3(laser.transform.position.x, laser.transform.position.y +3, laser.transform.position.z);
            }
            else{
                Floor -= 1;
                laser.transform.position = new Vector3(laser.transform.position.x, laser.transform.position.y -3, laser.transform.position.z);
            }
            Debug.Log("Space key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space key was released.");
        }  
    }
}
