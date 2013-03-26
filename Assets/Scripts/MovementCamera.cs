using UnityEngine;
using System.Collections;

public class MovementCamera : MonoBehaviour {
	
	private float x;
	private float y;
	//public float speed;
	public Transform target;
	public bool move;

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Players").transform; 
	}
	
	// Update is called once per frame
	void Update () {
		if(target.GetComponent<HUD>().meters > 20){
		//y =  Input.GetAxis("Vertical")* Time.deltaTime * speed;
		//x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
			if(move){
				transform.Translate(target.GetComponent<MovementScript>().x, -0.01f, 0);
			}else{
				transform.Translate(0, -0.01f, 0);
			}
		}
		
	}
}
