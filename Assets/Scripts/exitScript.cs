using System.Collections;
using UnityEngine;

public class exitScript : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        //End game with esc key 
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
