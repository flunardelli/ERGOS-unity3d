using UnityEngine;
using System.Collections;

public class InvasionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y<1.7) 
			Debug.Log ("invasion complete");
	
	}
	
}
