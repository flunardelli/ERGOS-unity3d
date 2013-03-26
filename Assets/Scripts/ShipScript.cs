using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {
	
	private int buttonWidth = 200, buttonHeight = 50;
	private bool gameover = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(GameObject.FindWithTag("Player")){
		//	Debug.Log ("Game On !");
			if(transform.position.y<1.7) {
				Debug.Log ("invasion complete");				
			}
		}else{
			gameover=true;
		}
	}	
	
	void OnGUI () 
    {
      if(gameover==true){
		if (GUI.Button(new Rect(Screen.width/2 - buttonWidth / 2, Screen.height /2 - buttonHeight /2, buttonWidth,buttonHeight),"GAME OVER \nJogar Novamente?"))
        {
            Application.LoadLevel(1);
        }	
	   }
	}
}
