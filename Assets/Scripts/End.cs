using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {
	
	//public Texture2D MainBackgroundTexture;
	public Texture2D MainLogoTexture;
	public Texture2D MainPressAnyButtonTexture;
	public float timer = 0;
	// Use this for initialization
	void Start () {
	
		//timer += Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 3) {
			timer = 0;	
		}
		timer += Time.deltaTime;
		
		if(Input.anyKeyDown) {
			Application.LoadLevel ("Credits");
		}
	}
	
	void OnGUI () {
		
		
		
		GUILayout.BeginVertical();	
			
			GUILayout.BeginHorizontal(GUILayout.Width(Screen.width),GUILayout.Height(Screen.height));
				GUILayout.FlexibleSpace();
					GUILayout.Label(MainLogoTexture,GUILayout.Width(800),GUILayout.Height(600));								
				GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
		
		
			GUILayout.BeginArea (new Rect (0,0,Screen.width,Screen.height));
			GUILayout.BeginVertical();	
			GUILayout.Space (60);
			GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();								
					
				GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			GUILayout.Space (430);
			if(timer <= 2) {	
				GUILayout.BeginHorizontal();
					GUILayout.FlexibleSpace();										
						
							GUILayout.Label(MainPressAnyButtonTexture,GUILayout.Width(400),GUILayout.Height(51));
											
					GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			} 
		
			
		GUILayout.EndArea();
		GUILayout.EndVertical();
		
		
	}
}
