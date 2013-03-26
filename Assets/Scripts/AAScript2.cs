using UnityEngine;
using System.Collections;

public class AAScript2 : MonoBehaviour {
	
	public Transform target;
	public Rigidbody bullet;
	public float power = 500;
	public float interval = 0.5f;
	public float lastShot = -10.0f;

	// Use this for initialization
	void Start () {
		 
	
	}
	
	// Update is called once per frame
	void Update () {
		target = GameObject.FindWithTag("Player").transform;
		transform.LookAt(target);
		
		Vector3 fwd = transform.TransformDirection (Vector3.up);
		
		if (Physics.Raycast(transform.position, target.position, 10)){  
						
			 if(Time.time > interval + lastShot){
       			Rigidbody clone = Instantiate(bullet, transform.position,transform.rotation) as Rigidbody;
			 	
				clone.rigidbody.velocity = transform.forward * power;
				
    			lastShot = Time.time;
				
    		}			
		}
	
	}
}
