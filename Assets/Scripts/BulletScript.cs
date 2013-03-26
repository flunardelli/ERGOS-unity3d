using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	//public AudioClip explosion;
	public Transform explosionPrefab;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 5);
	}
	bool hitEnemy = false;
	
	void OnTriggerEnter(Collider hit) { 
//		Debug.Log("Collider hit: " + hit.gameObject.tag);
		if(hit.gameObject.tag == "Player" && !hitEnemy) {
			//audio.PlayOneShot(explosion);
			Destroy(hit.gameObject);
			hitEnemy = true;
		}
		Instantiate(explosionPrefab, transform.position, transform.rotation);
		
		Destroy(gameObject);
	}
	
	void OnCollisionEnter(Collision hit) { 
		//Debug.Log("Collider hit: " + hit.gameObject.tag);
		if(hit.gameObject.tag != null  && !hitEnemy) {
//			audio.PlayOneShot(explosion);
			Destroy(hit.gameObject);
			hitEnemy = true;
			
		}
		Instantiate(explosionPrefab, transform.position, transform.rotation);
		
		Destroy(gameObject);
	}
}
