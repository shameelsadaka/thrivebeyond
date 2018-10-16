using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameRun : MonoBehaviour {
   public GameObject diverPrefab;
   public GameObject diver;
	// Use this for initialization
	public float oxygen;
    public Text oxygenText;
    public bool gameRunnig=false;
	public Time time;

	void Start () {
		gameRunnig=true;
		oxygen = 1000;
		GameObject loot= GameObject.CreatePrimitive(PrimitiveType.Quad);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		oxygen = oxygen -1;
		if(oxygen == 0){
			gameOver();
		}
		oxygenText.text= "OXYGEN:"+ oxygen.ToString() ;
	}
	void gameOver(){
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
	}
}
