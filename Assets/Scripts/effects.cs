using System.Collections;
using UnityEngine;

public class effects : MonoBehaviour
{
    public PlayerMovement movement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (gameObject.name =="Capsule"){
      transform.Rotate(3,0,0); 
      }
      if (gameObject.name =="coin"){
      transform.Rotate(0,0,3); 
      }
    }
}
