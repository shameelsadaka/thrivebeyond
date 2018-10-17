using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot{
    public int type;
	public string name;
	public float value;
	public Loot(int t){
		type = t;
		switch(t){
			case 0:// Mine
				break; 
			case 1:// Oxygen
				value = 20;
				break;
			case 2:// Coins
				value = Random.Range(10,100);
			break;

		}
	}
}
public class LootPrograms : MonoBehaviour {

	public string[] lootTypes = new string[] {"mine","oxygent","coins"};
	public Loot[] loots;
	void Start () {
		for (int i = 0; i < 100; i++)
		{
			loots[i] = new Loot(Random.Range(0,lootTypes.Length -1 ));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void ManageGameObjects(){
        
	}

}
