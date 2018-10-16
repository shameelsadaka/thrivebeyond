using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenCollection : MonoBehaviour {
public gameRun game;
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag =="Oxygen")
		{Destroy(col.gameObject);
		  game=GetComponent<gameRun>();
		  game.oxygen+=500;
		}

	}


}
