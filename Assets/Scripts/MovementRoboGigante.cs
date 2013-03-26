using UnityEngine;
using System.Collections;

public class MovementRoboGigante : MonoBehaviour {
	
	private float x;
	private float y;
	public float speed;

	// Use this for initialization
	void Start () {
		x = speed;
		//transform.GetComponentInChildren<Animation>().Play();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(x*Time.deltaTime, 0, 0);
	}
}
