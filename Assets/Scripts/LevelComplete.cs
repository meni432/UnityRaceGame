using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    //Level completed and a new level created
    public void LoadNextLevel(){
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    
    }
    
    
}
