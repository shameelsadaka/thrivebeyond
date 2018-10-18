
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
  
  public GameObject gameOverMenu;
  public GameObject button;
  public static bool gamehasEnded=false;

  void Awake(){
    FindObjectOfType<AnimatedTexture>().putGoingUpFalse();
    Time.timeScale=1;      
  }
   public void gameOver(){
       if(!gamehasEnded){
	    print("GAME OVER");
        gameOverMenu.SetActive(true);
       print(Time.timeScale);
        Time.timeScale=0;
       button.SetActive(false);
       }
   } 
   
  public void toMainMenu(){
      SceneManager.LoadScene("menu");
  }
   public void Restart(){
       gameOverMenu.SetActive(false);
      
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
       FindObjectOfType<AnimatedTexture>().putGoingUpFalse();
             Time.timeScale=1;
   }

   void Update(){
       if(FindObjectOfType<AnimatedTexture>().getGoingUp()){
              button.SetActive(false);
       }
   }
}
