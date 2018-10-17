using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	//variables
	public float moveSpeed = 300;
	public GameObject character;

	private float ScreenWidth;


	// Use this for initialization
	void Start () {
		ScreenWidth = Screen.width;
		
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		//loop over every touch found
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2)  {
				//move right
				RunCharacter (1.0f);
			}
			if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
				//move left
				RunCharacter (-1.0f);
			}
			++i;
 		}
	}
	void FixedUpdate(){
		#if UNITY_EDITOR
		RunCharacter(Input.GetAxis("Horizontal"));
		#endif
	}

	private void RunCharacter(float horizontalInput){
		//move player
		 var newTransform=character.transform;
         newTransform.transform.position+=new Vector3(horizontalInput* moveSpeed*Time.deltaTime,0.0f,0.0f);

	}
}