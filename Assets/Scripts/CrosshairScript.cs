using UnityEngine;
using System.Collections;

public class CrosshairScript : MonoBehaviour {
	
	public Texture2D crosshair;

	// Use this for initialization
	void Start () {
		
		Screen.showCursor = false;
	
	}

	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){			
				Vector3 mousePos = Input.mousePosition;
    			Rect pos = new Rect(mousePos.x, Screen.height - mousePos.y,crosshair.width, crosshair.height);
  				GUI.Label(pos, crosshair);	
	}
}
