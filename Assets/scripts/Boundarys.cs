using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundarys : MonoBehaviour {
	public GameObject player;
	private float playerwidth;
    private Vector2 screenBounds;
	// Use this for initialization
	void Start () {
		screenBounds=Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width,Screen.height,Camera.main.transform.position.z));
        		playerwidth=player.transform.GetComponent<SpriteRenderer>().bounds.size.x/2;
		

	}
	
	// Update is called once per frame
	void LateUpdate () {
		var newTransformPosition=player.transform.position;
		if(newTransformPosition.x>screenBounds.x-playerwidth){

		newTransformPosition.x=screenBounds.x-playerwidth;
        player.transform.position=newTransformPosition;
		}
		else if (newTransformPosition.x<-screenBounds.x+playerwidth){


		newTransformPosition.x=-screenBounds.x+playerwidth;
        player.transform.position=newTransformPosition;
		}
	}
}
