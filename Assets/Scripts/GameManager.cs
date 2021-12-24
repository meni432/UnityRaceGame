using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool gameHasEnded = false;
    
    public float restartDelay = 1f;
    
    public GameObject completeLevelUI;
    
    public void CompleteLevel(){
    
        completeLevelUI.SetActive(true);
    }
    
    //Restart as soon as the player loses
    public void EndGame(){
        
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    public void E() {
        
    }
    
    //Repeat game
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
