using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {
	

	public float power = 100f;
	public float m_timer = 0.6f, staytimer;
	public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		m_timer -= Time.deltaTime;
		if (Input.GetButtonDown("Fire1") && m_timer < 0) {
			Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
			//clone.velocity -= transform.up * power;
			//Destroy(clone.gameObject,2);			
			m_timer = staytimer;
		}	
	}
}
