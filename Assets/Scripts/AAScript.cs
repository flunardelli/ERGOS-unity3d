using UnityEngine;
using System.Collections;

public class AAScript : MonoBehaviour {
	
	//public Transform target;
	public Rigidbody bullet;
	public float power = 3000;
	public float interval = 0.5f;
	public float lastShot = -10.0f;
	
	private float m_interval;
	private float m_power;
	
	
	public float velocity = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if(target != null){
		m_interval = Random.Range(interval/2, interval);
		m_power = Random.Range(power/2, power);	
		
		Vector3 fwd = transform.TransformDirection (Vector3.up);
		RaycastHit hit;
		if (Physics.Raycast(transform.position, fwd, out hit, 100)){  
			 //Debug.DrawLine (transform.position, hit.point ,Color.red);
			if(hit.transform.tag == "Player"){
				 if(Time.time > m_interval + lastShot){
	       			Rigidbody clone = Instantiate(bullet, transform.position,transform.rotation) as Rigidbody;
				 	//instance.AddForce(fwd * power);
					clone.velocity = (transform.up * m_power) / velocity;
					//audio.PlayOneShot(colt);
	    			lastShot = Time.time;
					//Destroy(clone.gameObject, 1);
				}
    		}
		}
			Debug.DrawRay(transform.position, fwd*100, Color.green);
		//}
	}
}
