using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   //Startscreen mit Button erscheint
   public void StartGame(){
    
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   
   }
}
