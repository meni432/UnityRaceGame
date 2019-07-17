using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects : MonoBehaviour
{
    public PlayerMovement movement;
    public Vector3 rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    //
    transform.Rotate(rotation);
    
      if (gameObject.name =="coin"){
      transform.Rotate(0,0,3); 
      }
    }
}
