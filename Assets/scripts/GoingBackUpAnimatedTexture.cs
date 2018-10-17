using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingBackUpAnimatedTexture : MonoBehaviour {
    
	public void goUp(){
	   
		var animatedTexture= gameObject.GetComponent<AnimatedTexture>();
		print("going up!\n");
	    animatedTexture.putGoingUpTrue();
        
		
	}
	

	
	
	// Update is called once per frame
	
}
