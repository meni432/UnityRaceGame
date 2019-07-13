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

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 

        }

        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 

        }
        
        if (rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
        
        
    }
    //Coints einsammeln und zählen
     void OnTriggerEnter(Collider other){
        
        //grafik deaktivieren
        other.gameObject.GetComponent<Renderer>().enabled = false;
        
        //sound der Münze abspielen
        AudioSource audio = other.gameObject.GetComponent<AudioSource>();
        audio.Play();
        
        //Münze zerstören
        Destroy (other.gameObject, audio.clip.length);
        //other.gameObject.SetActive(false);
        points++;
    
            //Coins zählen
            text.text = "Coins: " + points;

            Debug.Log(points);
    }
}
