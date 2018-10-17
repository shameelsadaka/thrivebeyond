using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public float speed=2f;
	// Update is called once per frame
	void Update () {

	
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.position+=new Vector3(-speed*Time.deltaTime,0.0f,0.0f);
		}
		else if(Input.GetKey(KeyCode.RightArrow)){
			transform.position+=new Vector3(speed*Time.deltaTime,0.0f,0.0f);
		}

		
  
	}
	
	   
}
	

