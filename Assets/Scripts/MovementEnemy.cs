using UnityEngine;
using System.Collections;

public class MovementEnemy : MonoBehaviour {
	
	private float x;
	private float y;
	public float speed;

	// Use this for initialization
	void Start () {
		x = speed;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < 362){
			x = 1*Time.deltaTime*speed;
		}if(transform.position.x > 383){
			x = -1*Time.deltaTime*speed;
		}
		transform.Translate(x, 0, 0);
	}
}
