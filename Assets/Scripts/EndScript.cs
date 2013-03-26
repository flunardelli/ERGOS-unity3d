using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(0,0.001f,0);
		
		if(Input.anyKeyDown) {
			Application.LoadLevel ("Main");
		}
	
	}
}
