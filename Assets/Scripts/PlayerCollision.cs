 using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   
   public PlayerMovement movement;
   
   
       //This function runs when we hit another object
       //We get Information about the collision and call it "collisionInfo"
       void OnCollisionEnter(Collision collisionInfo){
        
        //play the sound of the obstacle
        AudioSource audio = collisionInfo.gameObject.GetComponent<AudioSource>();
        audio.Play();

            //Check if the object we collided with has a tag called "Hinderniss"
            if (collisionInfo.collider.tag == "Hinderniss"){
                movement. enabled = false;
                FindObjectOfType<GameManager>().EndGame();

            }

       }
}
