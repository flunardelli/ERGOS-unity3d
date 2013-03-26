using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	
	public float x;
	private float y;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift)){
			speed = 10;	
		}
		if (Input.GetKeyUp(KeyCode.LeftShift)){
			speed = 25;	
		}
		
		
//		print(transform.position.x);
		
		//y =  Input.GetAxis("Vertical")* Time.deltaTime * speed;
		
		//x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
		
		if(transform.position.x > 362 && transform.position.x < 383){
			if (Input.GetKey(KeyCode.LeftArrow)){
				x = -1*Time.deltaTime*speed;	
			}else if(Input.GetKeyUp(KeyCode.LeftArrow)){
				x = 0;
			}
			if (Input.GetKey(KeyCode.RightArrow)){
				x = 1*Time.deltaTime*speed;	
			}else if(Input.GetKeyUp(KeyCode.RightArrow)){
				x = 0;
			}
			transform.Translate(x, -0.01f, 0);
		}else if(transform.position.x < 362){
			x = 0;
			if (Input.GetKey(KeyCode.RightArrow)){
				x = 1*Time.deltaTime*speed;	
			}else if(Input.GetKeyUp(KeyCode.RightArrow)){
				x = 0;
			}
			transform.Translate(x, -0.01f, 0);
		}else if(transform.position.x > 383){
			x = 0;
			if (Input.GetKey(KeyCode.LeftArrow)){
				x = -1*Time.deltaTime*speed;	
			}else if(Input.GetKeyUp(KeyCode.LeftArrow)){
				x = 0;
			}
			transform.Translate(x, -0.01f, 0);
		}
	}
}
