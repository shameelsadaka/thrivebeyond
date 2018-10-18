using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class mainMenu : MonoBehaviour {
private Vector3 newTransfrom;
public TextMeshProUGUI textMesh;
public GameObject aboutMenu,Menu,optionsMenu;
public void  PlayGame()
{    
      
       SceneManager.LoadScene("game");

}	
void Awake(){
     newTransfrom=textMesh.transform.position;
}
public void opstions(){
    Menu.SetActive(false);
    optionsMenu.SetActive(true);
}
public void About(){
       textMesh.transform.position= newTransfrom;
       Menu.SetActive(false);
       aboutMenu.SetActive(true);
       Invoke("back",55);    
}
public void back(){
    aboutMenu.SetActive(false);
    optionsMenu.SetActive(false);
    Menu.SetActive(true);
}

}
