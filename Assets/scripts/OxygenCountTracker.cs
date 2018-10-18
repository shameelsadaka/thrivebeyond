using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class OxygenCountTracker : MonoBehaviour {
   
	// Use this for initialization
	public float oxygen;
    public TextMeshProUGUI oxygenText;
    public bool gameRunnig=false;
	public Time time;

	void Start (){
		gameRunnig=true;
		oxygen = 1000;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		oxygen = oxygen -1;
		if(oxygen == 0){
			FindObjectOfType<GameManager>().gameOver();
			
		} 
		oxygenText.text= "OXYGEN:"+ oxygen.ToString() ;
	}
	
}
