using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

   public float forwardForce = 2000f;
   public float sidewaysForce = 500f;
   
   private int points = 0;
   public TextMeshProUGUI text;
   
   

    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forwardForce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        //Press the "d" key to move the player to the right
        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 

        }
        //Press the "a" key to move the player to the left
        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 

        }
        
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
        
        
    }
    //Coints collect and count
     void OnTriggerEnter(Collider other){
        
        //Seactivate graphic
        other.gameObject.GetComponent<Renderer>().enabled = false;
        
        //Playing the sound of the coin
        AudioSource audio = other.gameObject.GetComponent<AudioSource>();
        audio.Play();
        
        // Destroy coin
        Destroy (other.gameObject, audio.clip.length);
        //other.gameObject.SetActive(false);
        points++;
    
            //Coins count
            text.text = "Coins: " + points;

            Debug.Log(points);
    }
}
