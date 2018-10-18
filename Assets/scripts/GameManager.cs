
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


   public void gameOver(){
	   print("GAME OVER");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

   }
}
