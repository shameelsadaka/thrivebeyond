using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixels_to_units=1f;
	 public static float scale=1f;
	
	
	public Vector2 nativeResolution=new Vector2(800,1280);

	void Awake(){
		var camera=GetComponent<Camera>();
		if(camera.orthographic){
			scale=Screen.height/nativeResolution.y;
			pixels_to_units*=scale;
			camera.orthographicSize=(Screen.height/2)/pixels_to_units;
		}
		
	}
}
