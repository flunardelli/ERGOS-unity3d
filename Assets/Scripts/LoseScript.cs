using UnityEngine;
using System.Collections;

public class LoseScript : MonoBehaviour 
{
    private int buttonWidth = 200, buttonHeight = 50;

	// Use this for initialization
    void Start()
    {

    }
    void Update()
    {

    }
	void OnGUI () 
    {
        if (GUI.Button(new Rect(Screen.width/2 - buttonWidth / 2, Screen.height /2 - buttonHeight /2, buttonWidth,buttonHeight),"GAME OVER \nJogar Novamente?"))
        {
            Application.LoadLevel(1);
        }
	
	}	
}
