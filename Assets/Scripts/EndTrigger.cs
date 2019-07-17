using UnityEngine;

public class EndTrigger : MonoBehaviour
{
   public GameManager gameManager;
  
   
   void OnTriggerEnter()
   {
        //Next Level
        gameManager.CompleteLevel();
        
    
   }
   
}
 