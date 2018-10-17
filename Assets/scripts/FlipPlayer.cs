using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPlayer : MonoBehaviour {

	
	float rotationAngle = 80;
    float smoothTime = 1.0f;
	private bool buttonPressed=false;
	public void goUp(){
	    
      buttonPressed=true; 
       
	}


	void Update(){
	  if(buttonPressed){   
		 
       Quaternion desiredRotation = Quaternion.Euler (0,0,rotationAngle);
       transform.rotation = Quaternion.Lerp (transform.rotation, desiredRotation, smoothTime);
 
	  }

    }
}
