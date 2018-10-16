using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilledBackground : MonoBehaviour {

	public int textureSize =32;
	public bool scaleHorizontal=true;
	public bool scalVertical= true;

	void Start () {
       var newWidth=!scaleHorizontal?1:Mathf.Ceil(Screen.width/(textureSize*PixelPerfectCamera.scale));
       var newHeight=!scalVertical?1:Mathf.Ceil(Screen.height/(textureSize*PixelPerfectCamera.scale));
       
	   transform.localScale=new Vector3(newWidth*textureSize ,newHeight*textureSize,1);

	   GetComponent<Renderer>().material.mainTextureScale=new Vector3(newWidth,newHeight,1);



	}
	
	
}
